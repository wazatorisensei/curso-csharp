using System;
using System.Globalization;

namespace CursoCsharp // Nota: o nome do namespace e preferivel sendo o nome do projeto por padrão.
{
  // variavel - <tipo> <nome> = <valor inicial>(opcional)
  // exemplos:
  // int idade = 25;
  // double altura = 1.68;
  // char sexo = 'F';
  // Uma variavel possui:
  // Nome (ou identificador)
  // Tipo
  /*
  Tipos básicos em C#
  byte : 0 .. 255
    >>> Um bit pode armazenar 2 valores possiveis (0 ou 1)
    >>> Cada bit = 2 possibilidades
    >>> 8bits: 2*2*2*2*2*2*2*2 = 2^8 = 256 possibilidades
  sbyte : -128 .. 127
  short : -32,768 .. 32,767
    >>> 16bits: 2^16 = 32,768 possibilidades
  ushort : 0 .. 65,535
  int : -2,147,484,648 .. 2,147,483,647
    >>> 4 bytes
  uint : 0 .. 4,294,967,295
  long : -9,223,372,036,854,775,808 .. 9,223,372,036,854,775,808
  ulong : 0 .. 18,446,744,073,709,551,615
  float : -3.402823e38 .. 3.402823e38
  double : -1.79769313486232e308 .. 1.79769313486232e308
  decimal : -79228162514264337593543950335 .. 79228162514264337593543950335
  char : A Unicode character.
  string : A string Unicode characters.
  bool : True or False.
  object : An object
  */
  // Valor
  // Endereço - onde na memória a variavel está.
  /* Como declarar variaveis */
  // 1. Não pode começar com dígito: use uma letra ou _.
  // 2. Não pode ter espaço em branco.
  // 3. Não usar acentos ou til.
  // 4. Sugestão: use o padrão "camel case" (ex: oiVariavel, tudoBem, comoVoceEsta).
  // Errado >>> Correto
  // int 5minutos; >>> int _5minutos;
  // int salário; >>> int salario;
  // int salário do funcionário; >>> int salarioDoFuncionario;
  class Program
  {
    static void Main(string[] args)
    {
      // double x = 10.35784;
      // string z = "Maria";
      // byte y = 32;
      // char w = 'F';
      // Console.WriteLine("Olá mundo!");
      // Console.WriteLine(">>>>>>>>>>>>>>");
      // Console.WriteLine("INICIO");
      // Console.WriteLine(x);
      // Console.WriteLine(x.ToString("F2"));
      // Console.WriteLine(x.ToString("F4"));
      // Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture));
      // Console.WriteLine("--------------");
      // Console.WriteLine("RESULTADO = " + x);
      // Console.WriteLine("O valor do troco é " + x + " reais.");
      // Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais.");
      // Console.WriteLine("--------------");
      // Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);
      // Console.WriteLine("--------------");
      // Console.ReadLine();
      // Console.WriteLine("FIM");
      // Console.WriteLine(">>>>>>>>>>>>>>");

      // /* Processamento de dados */
      // Console.WriteLine("INICIO");
      // int x2, y2;
      // x2 = 5;
      // y2 = 2 * x2;
      // Console.WriteLine(x2);
      // Console.WriteLine(y2);
      // Console.ReadLine();
      // Console.WriteLine("FIM");
      // Console.WriteLine(">>>>>>>>>>>>>>");

      // Console.WriteLine("INICIO");
      // int x3;
      // double y3;
      // x3 = 5;
      // y3 = 2 * x3;
      // Console.WriteLine(x2);
      // Console.WriteLine(y2);
      // Console.ReadLine();
      // Console.WriteLine("FIM");
      // Console.WriteLine(">>>>>>>>>>>>>>");

      // Console.WriteLine("INICIO");
      // /* formula de calculo da area de um quadrado */
      // // obs: double sempre inicia com .0 exemplo 4.0 e float sempre com f exemplo 4.5f.
      // double b, B, h, area;
      // b = 6.0;
      // B = 8.0;
      // h = 5.0;
      // area = (b + B) / 2.0 * h;
      // Console.WriteLine(area);
      // Console.ReadLine();
      // Console.WriteLine("FIM");
      // Console.WriteLine(">>>>>>>>>>>>>>");

      // Console.WriteLine("INICIO");
      // /* Exemplo 4 */
      // int a4, b4;
      // double resultado;
      // a4 = 5;
      // b4 = 2;
      // // resultado = a4 / b4;
      // // casting para que o resultado seja de outro tipo
      // resultado = (double)a4 / b4;
      // Console.WriteLine(resultado);
      // Console.ReadLine();
      // Console.WriteLine("FIM");
      // Console.WriteLine(">>>>>>>>>>>>>>");

      // Console.WriteLine("INICIO");
      // /* Exemplo 5 */
      // double a5;
      // int b5;
      // a5 = 5.0;
      // // casting para int...
      // b5 = (int)a5;
      // Console.WriteLine(b5);
      // Console.ReadLine();
      // Console.WriteLine("FIM");
      // Console.WriteLine(">>>>>>>>>>>>>>");

      /* ENTRADA DE DADOS AULA 1 */
      /* Para transcrever o que foi digitado no terminal */
      // string frase = Console.ReadLine();
      // string x = Console.ReadLine();
      // string y = Console.ReadLine();
      // string z = Console.ReadLine();

      // string[] v = Console.ReadLine().Split(' ');
      // string a = v[0];
      // string b = v[1];
      // string c = v[2];

      // Console.WriteLine("Você digitou: ");
      // Console.WriteLine(frase);
      // Console.WriteLine(x);
      // Console.WriteLine(y);
      // Console.WriteLine(z);
      // Console.WriteLine(a);
      // Console.WriteLine(b);
      // Console.WriteLine(c);

      /* ENTRADA DE DADOS AULA 2 */
      // int n1 = int.Parse(Console.ReadLine());
      // char ch = char.Parse(Console.ReadLine());
      // double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      // string[] vet = Console.ReadLine().Split(' ');
      // string nome = vet[0];
      // char sexo = char.Parse(vet[1]);
      // int idade = int.Parse(vet[2]);
      // double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

      // Console.WriteLine("Você digitou: ");
      // Console.WriteLine(n1);
      // Console.WriteLine(ch);
      // Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
      // Console.WriteLine(nome);
      // Console.WriteLine(idade);
      // Console.WriteLine(sexo);
      // Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

      /* EXERCICIO PROPOSTO */
      // Console.WriteLine("Entre com seu nome completo: ");
      // string nome = Console.ReadLine();
      // Console.WriteLine("Quantos quartos tem na sua casa?: ");
      // byte quartos = byte.Parse(Console.ReadLine());
      // Console.WriteLine("Entre com o preço do produto: ");
      // double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      // Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
      // string[] vet = Console.ReadLine().Split(' ');
      // string nomeUltimo = vet[0];
      // byte idade = byte.Parse(vet[1]);
      // double alturaPessoa = double.Parse(vet[2], CultureInfo.InvariantCulture);

      // Console.WriteLine(nome);
      // Console.WriteLine(quartos);
      // Console.WriteLine(preco.ToString("F2"), CultureInfo.InvariantCulture);
      // Console.WriteLine(nomeUltimo);
      // Console.WriteLine(idade);
      // Console.WriteLine(alturaPessoa.ToString("F2"), CultureInfo.InvariantCulture);

      double x = 3.0;
      double y = 4.0;
      double z = -5.0;
      double A, B, C;

      A = Math.Sqrt(x);
      B = Math.Sqrt(y);
      C = Math.Sqrt(25.0);

      Console.WriteLine("Raíz quadrada de " + x + " = " + A);
      Console.WriteLine("Raíz quadrada de " + y + " = " + B);
      Console.WriteLine("Raíz quadrada de 25 = " + C);

      A = Math.Pow(x, y);
      B = Math.Pow(x, 2.0);
      C = Math.Pow(5.0, 2.0);

      Console.WriteLine(x + " elevado a " + y + " = " + A);
      Console.WriteLine(x + " elevado ao quadrado " + B);
      Console.WriteLine("5 elevado ao quadrado = " + C);

      A = Math.Abs(y);
      B = Math.Abs(z);
      Console.WriteLine("Valor absoluto de " + y + " = " + A);
      Console.WriteLine("Valor absoluto de " + z + " = " + B);
    }
  }
}