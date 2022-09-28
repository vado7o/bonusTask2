// Напишите программу, которая на вход принимает букву, необходимо создать массив из 5 названий городов, 
// и вывести на экран те (тот), где чаще всего встречается введённая буква.

Console.Clear();
Console.WriteLine("Задача со звёздочкой: программа, выдающая город, в названии которого чаще всего встречается введённая буква");
string[] cities = new string[] {"Москва", "Тюмень", "Новосибирск", "Томск", "Нижневартовск"}; 

char letter = ' ';
List<string> city = new List<string>();
int quantity = 0;
int nextQuantity = 0;

while(true) {
Console.WriteLine("\nВведите любую букву русского алфавита:");
if(char.TryParse(Console.ReadLine(), out letter)) {
    foreach(string i in cities) {
        nextQuantity = 0;
        char[] charArray = i.ToCharArray();
        for(int m = 0; m <= charArray.Length - 1; m++) {
            if(charArray[m] == letter) nextQuantity++;
        }
        if(nextQuantity > quantity) {
            quantity = nextQuantity;
            city.Clear();
            city.Add(i);
        }
        else if(nextQuantity == quantity) {
            city.Add(i);
        }
    }
    break;
} else Console.WriteLine("неправильно введена буква\n");
}

Console.WriteLine("\nСреди городов: Москва, Тюмень, Новосибирск, Томск, Нижневартовск");
if(quantity == 0) {
    Console.WriteLine("введённая Вами буква НЕ встречается ни в одном слове!");
} else {
    Console.WriteLine("введённая Вами буква <" + letter + "> чаще всего встречается в слове: ");
    foreach(string item in city) {
        Console.WriteLine(item.ToString());
    }
}
