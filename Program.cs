using System;
using System.Collections;
using System.Collections.Generic;
namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
           //system.collections namespace
           ArrayList liste = new ArrayList();
           liste.Add("yavuz");
           liste.Add(3);
           liste.Add(true);
           liste.Add('A');

           //içerisindeki verilere erişim
           Console.WriteLine(liste[1]);
           foreach (var item in liste)
           Console.WriteLine(item);

           //AddRange
           Console.WriteLine("***** Add Range*****");
           string[] renkler = {"kırmızı","turuncu","siyah"};
           List<int> sayılar= new List<int>(){1,2,3,4,5,6,7};
           liste.AddRange(renkler);
           liste.AddRange(sayılar);
           foreach (var item in liste)
           Console.WriteLine(item);

           //sort-sıralama
           Console.WriteLine("****sort****");
           liste.Sort();// içerisinde string ifadeler olduğu için runtime da hata verir

           //binary search
           Console.WriteLine("****binary search****");
           liste.BinarySearch(6); //6 elemanının indexini getirir

           //Reverse
           Console.WriteLine("****Reverse****");
           liste.Reverse();//sırayı tersine çevirir

           //clear
           liste.Clear();

           

            
        
           


        }
    }
}
