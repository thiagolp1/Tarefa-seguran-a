
Console.WriteLine("Digite uma frase:");
string frase = Console.ReadLine();

Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());

string fraseMaiuscula = frase.ToUpper(); 

string fraseAlterada = AumentarLetrasNoAlfabeto(fraseMaiuscula, numero);

Console.WriteLine("Frase original: " + frase);
Console.WriteLine("Frase alterada: " + fraseAlterada);


static string AumentarLetrasNoAlfabeto(string frase, int numero)
{
char[] letras = frase.ToCharArray();
string novaFrase = "";

foreach (char letra in letras)
{
if (char.IsLetter(letra)) 
{
char novaLetra = (char)(((letra - 'A' + numero) % 26) + 'A'); 

novaFrase += novaLetra;
}
else
{
novaFrase += letra; 
}
}

return novaFrase;
}

