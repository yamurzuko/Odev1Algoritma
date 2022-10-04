using System;

namespace Odev1Algoritma
{
    static class Program
    {
        static void Main(string[] args)
        {
            /*   ************** Soru 1 **************


                int n;
                Console.WriteLine("Lütfen Pozitif Bir Sayi Giriniz: ");
                while(true)
                {
                    n = int.Parse(Console.ReadLine());
                
                    if(n <= 0 || Convert.ToString(n) == null)
                    {
                        Console.WriteLine("Hata Tekrar Giriniz:");
                        continue;
                    }
                    break;
                }
                
                List<int> list = new List<int>();
                int temp;
                Console.WriteLine("Lütfen " + n + " adet sayi giriniz: ");

                while (list.Count != n)
                {
                    temp = int.Parse(Console.ReadLine());
                    if(temp > 0 )
                    {
                        list.Add(temp);
                    }
                    else
                    {
                        Console.WriteLine("Hata Pozitif Sayi giriniz:");
                        continue;
                    }
                }
                Console.WriteLine("Pozitif Sayilar: ");
                foreach(var item in list)
                {
                    if(item % 2 == 0)
                    {

                        Console.WriteLine(item);
                    }
                }

            */
            
            /*  ************** Soru 2 ***************


            int n, m;

            Console.WriteLine("İki sayi giriniz: ");
            

            while(true)
            {
                n = int.Parse(Console.ReadLine());
                m = int.Parse(Console.ReadLine());

                if(n <= 0 || Convert.ToString(n) == null || m <= 0 || Convert.ToString(m) == null)
                {
                    Console.WriteLine("Hata Tekrar Giriniz:");
                    continue;
                }
                break;
            }
            List<int> list = new List<int>();
            int temp;
            Console.WriteLine("Lütfen " + n + " adet sayi giriniz: ");

            while (list.Count != n)
            {
                temp = int.Parse(Console.ReadLine());
                if(temp > 0 )
                {
                    list.Add(temp);
                }
                else
                {
                    Console.WriteLine("Hata Pozitif Sayi giriniz:");
                    continue;
                }
            }
            Console.WriteLine("Pozitif Sayilar: ");
            foreach(var item in list)
            {
                if(item % m == 0)
                {

                    Console.WriteLine(item);
                }
            }
            */


            /*         ********** Soru 3 **********


            int n;
            Console.WriteLine("Lütfen Pozitif Bir Sayi Giriniz: ");
            while(true)
            {
                n = int.Parse(Console.ReadLine());
            
                if(n <= 0 || Convert.ToString(n) == null)
                {
                    Console.WriteLine("Hata Tekrar Giriniz:");
                    continue;
                }
                break;
            }

            List<string> list = new List<string>();
            string temp;
            Console.WriteLine("Lütfen " + n + " adet kelime giriniz: ");

            while (list.Count != n)
            {
                temp = Console.ReadLine();

                if(!IsNumeric(temp))
                {
                    list.Add(temp);
                }
                else
                {
                    Console.WriteLine("Hata Kelime Giriniz:");
                    continue;
                }
            }
            list.Reverse();
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            
            public static bool IsNumeric(string text)
            {
                foreach (char chr in text)
                {
                    if (!Char.IsNumber(chr)) return false;
                }
                return true;
            }

            */

            /*      ************* Soru 4 *************

            string temp;
            Console.WriteLine("Lütfen Cümle Giriniz: ");

            while (true)
            {
                temp = Console.ReadLine();

                if(IsNumeric(temp))
                {
                    Console.WriteLine("Hata Kelime Giriniz:");
                    continue;
                }
                else
                {
                    break;
                }
            }
            int characterCount = RemoveSpaces(temp).Count();
            string[] word = temp.Split(' ');
            Console.WriteLine("Cümledeki harf sayisi: " + characterCount);
            Console.WriteLine("Cümledeki Kelime Sayisi: " + word.Length);
            }
            public static bool IsNumeric(string text)
            {
                foreach (char chr in text)
                {
                    if (!Char.IsNumber(chr)) return false;
                }
                return true;
            }
            public static string RemoveSpaces(this string param)
            {
                string[] array = param.Split(" ");
                return string.Join("",array);
            }
            */
        }
    }
}