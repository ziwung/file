using System;
using System.Linq;
using System.Collections.Generic;
// class Ex
// {
//     static void Main()
//     {
//         string input = Console.ReadLine()?? "5";
//         if(int.TryParse(input,out int K)){};
//         int[] dist = new int[K+1];   //K=1일 경우 대비
//         Array.Fill(dist, int.MaxValue);
//         PriorityQueue<int,int> pq = new PriorityQueue<int, int>();
//         dist[1] = 1;
//         pq.Enqueue(1, 1);
//         while (pq.Count > 0)
//         {
//             pq.TryDequeue(out int currentNum, out int currentSum);
            
//             if(dist[currentNum]<currentSum) continue;
//             if (currentNum == 0)
//             {
//                 Console.WriteLine(currentSum);
//                 break;
//             }
            
//             int nextNum = currentNum*10%K;
//             int nextSum = currentSum;
//             if (dist[nextNum] > currentSum)
//             {
//                 dist[nextNum] = currentSum;
//                 pq.Enqueue(nextNum, nextSum);
//             }

//             if (dist[(currentNum + 1) % K] > currentSum + 1)
//             {
//                 dist[(currentNum + 1) % K] = currentSum + 1;
//                 pq.Enqueue((currentNum + 1) % K, currentSum + 1);
//             }
//         }
//     }
// }
