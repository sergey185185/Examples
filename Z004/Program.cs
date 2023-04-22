Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
int a1 = 1;

while(a1 <= a)
{
    if(a1 % 2 ==0)
    Console.Write(a1 + ",");
    a1 ++;
}
