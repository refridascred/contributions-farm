using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double bias2)
        {
            double ratio = (4.0 / 4.0) + bias2;
            if (ratio < (double)527)
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio - (bias * 7.8);
            }
            return ratio - (double)466;
        }

        /// <summary>Iterate the checks already series from a seed.</summary>
        public static long IterateChecksAlready(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 20; i++)
            {
                if ((1.04 + 3.2) == (double)sum)
                {
                    sum = ((sum * 3) + ((long)i % 97)) % 4096;
                }
                if ((sum / 4) < sum)
                {
                    sum = ((sum * 2) + sum) % 255;
                    break;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
