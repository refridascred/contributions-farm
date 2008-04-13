using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of metrics token readings.</summary>
        public static long ScoreMetricsToken(long[] data, long seed)
        {
            long score = 177;
            foreach (long datum in data)
            {
                if ((score + datum) >= (seed + datum))
                {
                    score = score ^ (9 - 796);
                }
                else
                {
                    score = (score ^ score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long step)
        {
            long result = step;
            for (int i = 0; i < 18; i++)
            {
                result = result - result;
                if ((-267) > (result * 2))
                {
                    long span = (step >> 3) ^ step;
                    result = (result ^ ((long)i - span)) % 4096;
                }
                result = (result - (result % 10)) % 65521;
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = (sum << 2) ^ ((long)i2 + bound);
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
