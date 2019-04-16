using System;
using SENAIzinho;

namespace Projeto_SENAIzinho
{
    class Programa
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[2];
            Sala[] salas = new Sala[2];
            int contadorAlunos = 0;
            int contadorSalas = 0;
            bool sair = true;

            do
            {
                Console.WriteLine("==============================");
                Console.WriteLine("||Bem vindo ao SENAIzinho  ||");
                Console.WriteLine("||Escolha uma opção        ||");
                Console.WriteLine("||1 - Cadastrar Aluno      ||");
                Console.WriteLine("||2 - Cadastrar Sala       ||");
                Console.WriteLine("||3 - Alocar Aluno         ||");
                Console.WriteLine("||4 - Remover Aluno        ||");
                Console.WriteLine("||5 - Verificar Salas      ||");
                Console.WriteLine("||6 - Verificar Alunos     ||");
                Console.WriteLine("||0 - Sair                 ||");
                Console.WriteLine("==============================");
                Console.Write("Opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        // cadastrar aluno
                        if (contadorAlunos < 4)
                        {
                            Aluno a = new Aluno();
                            Console.Write("Digite o nome do aluno: ");
                            a.Nome = Console.ReadLine();
                            Console.Write("Digite a data de nascimento do aluno: ");
                            a.DataNascimento = DateTime.Parse(Console.ReadLine());
                            Console.Write("Digite o curso do aluno: ");
                            a.Curso = Console.ReadLine();
                            Console.Write("Digite o número da sala do aluno: ");
                            a.NumeroSala = int.Parse(Console.ReadLine());
                            alunos[contadorAlunos] = a;
                            contadorAlunos++;
                        } //fim do if
                        break;
                    case 2:
                        if (contadorSalas < 1)
                        {

                            Sala s = new Sala();
                            Console.Write("Digite o número da sala: ");
                            s.NumeroSala = int.Parse(Console.ReadLine());
                            Console.Write("Digite a capaciadede máxima da sala: ");
                            s.CapacidadeTotal = int.Parse(Console.ReadLine());
                            s.CapacidadeAtual = s.CapacidadeTotal;

                            s.Alunos = new string[s.CapacidadeTotal];

                            salas[contadorSalas] = s;
                            contadorSalas++;
                        } // fim do if.
                        break;
                    case 3:
                        Console.WriteLine("Digite o nome do Aluno que você deseja alocar: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite o n° da sala: ");
                        int numeroSala = int.Parse(Console.ReadLine());
                        foreach (var item in salas)
                        {
                            
                        }

                        break;
                    case 4:
                    Console.WriteLine("Digite o nome do aluno você deseja remover");
                    Console.ReadLine();

                        break;
                    case 5:
                        foreach (var item in salas)
                        {
                            Console.WriteLine("------------------");
                            Console.WriteLine($"Número da sala{item.NumeroSala}");
                            Console.WriteLine($"Número da sala{item.CapacidadeAtual}");
                            Console.WriteLine("------------------");
                        }
                        break;
                    case 6:
                        foreach (var item in alunos)
                        {
                            if (item!null){
                                Console.WriteLine("--------------");
                                Console.WriteLine($"Nome do aluno{item.Nome}");
                                Console.WriteLine($"Curso: {item.Curso}");
                                Console.WriteLine("");
                            }
                        }
                    default:

                        break;
                }

            }
        }
        while (!sair);
    }
}
}

//                     case 3:
//                         Console.WriteLine ("Digite o nome do aluno que você deseja mover");
//                         string nomeAluno = Console.ReadLine ();
//                         Console.Write ("Digite o número da sala para qual deseja movê-lo(a): ");
//                         int numeroSala = int.Parse (Console.ReadLine ());
//                         Aluno AlunoParaMover;
//                         for (int i = 0; i < salas.Length; i++) {
//                             if (salas[i] != null) {
//                                 if (alunos[i].nome == nomeAluno && alunos[i] != null) {
//                                     AlunoParaMover = alunos[i];
//                                     if (salas[i].numeroSala == numeroSala) {
//                                         salas[i].AlocarAluno (AlunoParaMover, numeroSala);
//                                     }
//                                 }
//                             } else {
//                                 break;
//                             }
//                         }
//                         break;
//                     case 4:
//                         break;
//                     case 5:
//                         for (int i = 0; i < salas.Length; i++) {
//                             if (salas[i] != null) {
//                                 Console.WriteLine ($"SALA {salas[i].numeroSala}");
//                                 Console.WriteLine ($"Capacidade total da sala: {salas[i].capacidadeTotal}");
//                             }
//                         }
//                         break;
//                     case 6:
//                         for (int i = 0; i < alunos.Length; i++) {
//                             if (alunos[i] != null) {

//                                 Console.WriteLine ($"Nome do aluno {alunos[i].nome}");
//                                 Console.WriteLine ($"Data de nascimento do aluno; {alunos[i].dataNascimento:dd/MM/yyyy}");
//                                 Console.WriteLine ($"Curso do aluno: {alunos[i].Curso}");
//                                 Console.WriteLine ($"Número da sala do aluno: {alunos[i].numeroSala}");
//                             }
//                         }

//                         break;
//                     case 0:
//                         Console.WriteLine ("Você selecionou sair");
//                         noMenu = false;
//                         break;
//                     default:
//                         break;
//                 }
//                 if (noMenu) {
//                     Console.WriteLine ("Pressione ENTER para voltar ao menu principal");
//                     Console.ReadLine ();
//                 } else {
//                     Console.WriteLine ("Pressione ENTER para finalizar o programa");
//                     Console.ReadLine ();
//                 }
//                 Console.Clear ();
//           }
//      }