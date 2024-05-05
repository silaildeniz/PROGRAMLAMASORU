using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMLAMASORU
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TEK SAYI BULDURNA PROGRAM
            int[] diziler = new int[10];
            int tane = 0;
            Random rnd = new Random();
            for (int i = 0; i < diziler.Length; i++)
            {
                diziler[i] = rnd.Next(0, 10);
                Console.WriteLine("dizinin {0}. elemanı {1}",i+1,diziler[i]);
                if (diziler[i]%2 ==1)
                {
                    tane++;
                }
            }
            Console.WriteLine("{0} adet tek sayı vardır", tane);











            
            //METİNDEKİ SESLİ VE SESSİZ HARFLERİ BULAN PROGRAM
            String cumle;
            int sayacsesli = 0;
            int sayacsessiz = 0;
            int sayacsembol = 0;
            Console.WriteLine("Metni Giriniz");
            cumle = Console.ReadLine();

            char[] sesliharfler = { 'a', 'e', 'i', 'o', 'u', 'ö', 'ü', 'ı' };
            char[] sembol = { '1', '2', '#', '%', '8', '_', '.', ',', '(', ')' };

            for (int i = 0; i < cumle.Length; i++)
            {
                for (int j = 0; j < sesliharfler.Length; j++)
                {
                    if (cumle[i] == sesliharfler[j])
                    {
                        sayacsesli++;
                    }
                }
                for (int k = 0; k < sembol.Length; k++)
                {
                    if (cumle[i] == sembol[k])
                    {
                        sayacsembol++;
                    }
                }
            }
            sayacsessiz = cumle.Length - (sayacsesli + sayacsembol);
            Console.WriteLine("Sesli harf Sayısı" + sayacsesli);
            Console.WriteLine("Sessiz harf Sayısı" + sayacsessiz);
            Console.WriteLine("Sembol Sayısı" + sayacsembol);

            // RASTGELE OLUŞTURULAN MATRİSİN SATIR VE SÜTUN TOPLAMLARINI BULAN PROGRAM

            int[,] dizi = new int[10, 10];
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    dizi[i, j] = rnd.Next(10);
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
          
           
            for (int m = 0; m < 10; m++)
            {
                int sutun_toplam = 0;
                int satır_toplam = 0;
                for (int n = 0; n < 10; n++)
                {
                    satır_toplam += dizi[m, n];
                    sutun_toplam += dizi[n, m];
                }
                Console.WriteLine("{0}. Satırın Toplamı\t: {1}\t\t{2}. SütununToplamı\t: {3}", (m + 1), satır_toplam, (m + 1), sutun_toplam);
            }

            Console.ReadKey();
            

            Console.WriteLine("Satır sayısını giriniz");
            int satir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Satır sayısını giriniz");
            int sutun = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[satir, sutun];

            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.WriteLine("Lütfen {0}x{1} elemanını giriniz", i + 1, k + 1);
                    matris[i, k] = Convert.ToInt32(Console.ReadLine());
                    Console.Write(matris[i, k] + " ");
                }
            }
            //Normal matrisi ekrana yazdırma
            
             Console.WriteLine();
            
            //Transpozunu ekrana yazdırma :
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.Write(matris[k, i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
           
            //matrisin reel bir sayı ile çarpılması

            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.Write(matris[i, k] * 4 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            //transpozunun reel sayı ile çarpılması
            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.Write(matris[i, k] * 5 + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            //kare matris için veya satır ve sutunu eşit olan bir matris için toplama çıkarma :

            for (int i = 0; i < satir; i++)
            {
                for (int k = 0; k < sutun; k++)
                {
                    Console.Write(matris[k, i] - matris[i, k] + " ");    //Matrisin transpozundan matrisin kendisini çıkardık.Kural gereği satır ve sutun sayıları eşit olmalı.
                }
                Console.WriteLine();
            }
            */
        }

    }
}
