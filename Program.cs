using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkUyg
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            int parkCapacity = 10; // otopark kapasitesi
            int availableSpaces = parkCapacity; // otoparkta boş yer sayısı
            string[] parkedCars = new string[parkCapacity]; // otoparktaki araçlar

            while (true)
            {
                Console.WriteLine("Otoparka hoş geldiniz!");
                Console.WriteLine("1. Araç park et");
                Console.WriteLine("2. Araç çıkar");
                Console.WriteLine("3. Otoparktaki araçları listele");
                Console.WriteLine("4. Otoparktaki boş yer sayısını görüntüle");
                Console.WriteLine("0. Çıkış");
                Console.Write("Seçiminiz: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1": // Araç park et
                        if (availableSpaces == 0)
                        {
                            Console.WriteLine("Maalesef otopark dolu!");
                            break;
                        }

                        Console.Write("Araç plakası: ");
                        string carPlate = Console.ReadLine();

                        for (int i = 0; i < parkCapacity; i++)
                        {
                            if (parkedCars[i] == null)
                            {
                                parkedCars[i] = carPlate;
                                availableSpaces--;
                                Console.WriteLine("Araç park edildi.");
                                break;
                            }
                        }

                        break;

                    case "2": // Araç çıkar
                        Console.Write("Araç plakası: ");
                        string exitingCarPlate = Console.ReadLine();

                        for (int i = 0; i < parkCapacity; i++)
                        {
                            if (parkedCars[i] == exitingCarPlate)
                            {
                                parkedCars[i] = null;
                                availableSpaces++;
                                Console.WriteLine("Araç çıkarıldı.");
                                break;
                            }
                        }

                        break;

                    case "3": // Otoparktaki araçları listele
                        Console.WriteLine("Otoparktaki araçlar:");

                        for (int i = 0; i < parkCapacity; i++)
                        {
                            if (parkedCars[i] != null)
                            {
                                Console.WriteLine(parkedCars[i]);
                            }
                        }

                        break;

                    case "4": // Otoparktaki boş yer sayısını görüntüle
                        Console.WriteLine("Otoparkta boş yer sayısı: " + availableSpaces);
                        break;

                    case "0": // Çıkış
                        Console.WriteLine("Otoparktan çıkılıyor...");
                        return;

                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}