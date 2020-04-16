using System;
using System.Collections.Generic;
using System.Linq;


namespace Hashmap_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialization of the differant type of Dictionaries
            //As you can see we declared the dictionary with keys and values.
            //Below four initializations we used four combinations of string and int variable types.
            Dictionary<string, string> dic = new Dictionary<string, string>();
            Dictionary<string, int> dic_int = new Dictionary<string, int>();
            Dictionary<int, string> dic_string = new Dictionary<int, string>();
            Dictionary<int, int> dic_both_int = new Dictionary<int, int>();

            //Also you can initialize it with interface.
            IDictionary<string, string> idic = new Dictionary<string, string>();

            //You can also declare and initialize the dictionary with the values.
            //Here we initialized the dictionary with values.
            Dictionary<string, string> dic_with_values = new Dictionary<string, string> {
                { "key1", "value1" }, { "key2", "value2" }, { "key3", "value3" }
            };

            //To add some data we use Add method which declared in Dictionary
            //We can add datas directly or with KeyValuePairs.
            //Directly adding is simple
            dic.Add("key", "value");
            dic.Add("web", "https://thecodeprogram.com");
            dic_int.Add("int_value", 33);

            //Adding the datas with KeyValuePairs is more simple :)
            //But you can use this with interface declared.
            //You can not use this specification with directly declared with Dictionary.
            KeyValuePair<string, string> key_valuePair = new KeyValuePair<string, string>("string_key", "string_value");
            idic.Add(key_valuePair);

            //We can remove data with keys. 
            dic.Remove("key");
            //Also we can remove datas with KeyValue Pairs
            idic.Remove(new KeyValuePair<string, string>("string_key", "string_value"));

            //We can get the datas with the keys and print to the screen
            Console.WriteLine(dic["web"]);
            //Or you can get the datas with the keys and values via index
            Console.WriteLine(dic_with_values.ElementAt(0));



            //We can also make the searchment with the keys and datas.
            //To search some key in the keys we will use the ContainsKey method
            //and we use theContainsValue to search in the values.
            if (dic_with_values.ContainsKey("key1")) Console.WriteLine("Key1 is exist");
            if (!dic_with_values.ContainsKey("thekey")) Console.WriteLine("thekey is not exist.");

            if (dic_with_values.ContainsValue("value1")) Console.WriteLine("value1 is exist");
            if (!dic_with_values.ContainsValue("thevalue")) Console.WriteLine("thevalue is not exist.");


            Console.ReadLine();

        }
    }
}
