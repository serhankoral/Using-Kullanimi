/*
 * Using anahtar kelimesi var olan diğer namespace leri programa dahil etmek için kullanılır
 * static classları direk ismi olmadan alt foksiyonlara ulaşmak istersek kullanırız
 * using bir nesne ile kullanıldığında onu daha rahat kullanılmasını sağlar ve nesne ile iş bitince dispose eder yani yok ederek ram den alan açar
 */
using static System.Console;//burda static olan komutları baş kısmı olmadan kullanmamızı sağladı    
using static Using_Kullanimi.Kontrol;


namespace Using_Kullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WriteLine("Hello, World!");
            Print("Hello, World!");
            MyClass test= new MyClass();
            test.Dispose();
            Console.WriteLine("Using Anahtar Kelimesinin Kullanımı");
            using (MyClass test2=new MyClass())
            {
                WriteLine("MyClass Test2 olarak oluşturuldu");
            }
        }
    }
    class Kontrol
    {
        public static void Print(string text)
        {
            WriteLine(text);
        }
    }
    class MyClass :IDisposable
    { 
        public void Dispose() 
        {
            WriteLine("Myclass Dispose Edildi");
        } 
    }
}