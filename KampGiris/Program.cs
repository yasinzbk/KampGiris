using System;

namespace KampGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.urunNumarasi = 1;
            urun1.urunAdi = "elma";

            Urun urun2 = new Urun();
            urun2.urunAdi = "kel mahmut";
            urun2.urunNumarasi = 2;

            Urun[] urunler =new Urun[] { urun1, urun2 };

            // Console.WriteLine("Hello World!");


            /*  for(int i=0; i<2; i++)
              {
                  Console.WriteLine(urunler[i].urunAdi + " " + "numarası: " + urunler[i].urunNumarasi);
              }*/

            /* int i=0;
             while (i<2)
             {
                 Console.WriteLine(urunler[i].urunAdi + " " + "numarası: " + urunler[i].urunNumarasi);
                 i++;

             }*/


            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.urunAdi + " " + "numarası: " + urun.urunNumarasi);
            }


          }




        class Urun
        {
          
            public int urunNumarasi { get; set; }
            public string urunAdi { get; set; }





        }
    

    }
        }
    

