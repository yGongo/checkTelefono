using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {

        for(int i=0;i<input.Length; i++){
            if(input[i]!=""){
                for(int x=0;x<input[i].Length;x++){
                    if(input[i][x]==' '){
                        i++;                        
                    }
                }
                if(input[i][2]=='3' && input[i][3]=='9'&& input[i][0]!='3' && input[i][1]!='3'){
                    return input[i];
                }else if(input[i][0]=='3'&&input[i][5]!='1'){
                    return input[i];
                }else if(input[i][1]=='3' && input[i][2]=='9'&&input[i][0]=='+'){
                    return input[i];
                }
            }
        }
        return "";
    }
}