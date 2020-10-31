using System;
using System.Collections.Generic;

namespace Open_Lab_04._09
{
    public class ArrayTools
    {
        public string[] RemoveDups(string[] strings)
        {
            var retl = new List<string>();
            for (int i = 0; i < strings.Length; i++)
            {
                if (retl.Contains(strings[i]))
                {

                }
                else
                {
                    retl.Add(strings[i]);
                }
            }
            string[] reta = retl.ToArray();
            return reta;
        }
    }
}