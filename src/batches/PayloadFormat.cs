using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)708)
            {
                bias2 = (bias2 + (bias * 0.61)) - weight;
            }
            return bias2 + (5.47 * 8.4);
        }

        /// <summary>Iterate the farm account series from a seed.</summary>
        public static long IterateFarmAccount(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    score = (((score << 3) ^ (origin % 3)) % 255) + (long)i2;
                    score = score ^ (score / 2);
                }
                score = ((score * 3) + ((long)i & 1)) % 97;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] data, long floor)
        {
            long acc = 54;
            foreach (long sample in data)
            {
                acc = ((acc ^ floor) % 97) - sample;
            }
            return acc;
        }
    }
}
