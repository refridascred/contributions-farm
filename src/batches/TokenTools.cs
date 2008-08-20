using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = (double)(243 >> 1);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (double)877) - (double)(long)i) - gain) + floor;
            }
            return mean + (double)0;
        }

        /// <summary>Find the first format githubfarm entry that matches the target.</summary>
        public static long FindFormatGithubfarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes already value from a seed.</summary>
        public static long RollNotesAlready(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = (acc ^ (acc + limit)) + (long)i2;
                }
                acc = ((acc << 3) ^ (acc ^ (long)i)) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
