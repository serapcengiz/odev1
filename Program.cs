using System;
namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CiftBul();
            EsitYaDaTamBoluneniBul();
            SondanBasaYaz();
            KelimeVeHarfSayısınıBul();
            

        }
        public static void CiftBul()
        {
            //klavyeden girilen n tane sayının çift olanları yazdırır
            Console.WriteLine("eleman sayısını giriniz:");
            int n=int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[n];

            for(int i=0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz",i+1);
                 sayiDizisi[i]=int.Parse(Console.ReadLine());
            }
            foreach(var sayi in sayiDizisi)
            {
                if(sayi%2==0)
                    {
                        Console.WriteLine(sayi);
                    }
            }
        }
        public static void EsitYaDaTamBoluneniBul()
        {
            //klavyeden girilen n tane sayının m e eşit ya da tam bolunduğubnu bulur
            Console.WriteLine("eleman sayısını giriniz:");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Bölünecek sayıyı giriniz");
            int m=int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[n];

            for(int i=0; i < n; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz",i+1);
                 sayiDizisi[i]=int.Parse(Console.ReadLine());

            }
            
            for(int i=0; i<n;i++)
            {
                if(sayiDizisi[i]%m==0)
                    {
                        Console.WriteLine(sayiDizisi[i]);
                    }
            }
        }
        public static void SondanBasaYaz()
        {
            //klavyeden girilen n tane sayının m e eşit ya da tam bolunduğubnu bulur
            Console.WriteLine("kelime sayısını giriniz:");
            int n=int.Parse(Console.ReadLine());
            string[] sayiDizisi = new string[n];

            for(int i=0; i < n; i++)
            {
                Console.Write("Lütfen {0}. kelimeyi giriniz",i+1);
                 sayiDizisi[i]=Console.ReadLine();

            }
            Array.Reverse(sayiDizisi);
            foreach(var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

        }
        public static void KelimeVeHarfSayısınıBul()
        {
            //klavyeden girilen n tane sayının m e eşit ya da tam bolunduğubnu bulur
            Console.WriteLine("Bir Cümle yazınız:");
            string n=Console.ReadLine();

            string[] sayiDizisi = n.Split(" ");
            string.Join("",sayiDizisi);
            int elemanSayisi=sayiDizisi.Count();
            Console.WriteLine("Cümledeki kelime sayısı: "+elemanSayisi);
            
            string str = n;
            
            int count = 0;
            int l=str.Length;
            
            for(int i=0;i<l;i++)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    count++;
                }
            }
            Console.WriteLine("Cümlede {0} harf vardır",count);

            

            
        }

    }
}
