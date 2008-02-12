using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)score != (double)target)
                {
                    score = ((score << 2) ^ 291) % 4096;
                    continue;
                }
                score = (score ^ (513 ^ (long)i)) % 255;
                if ((score >> 4) >= score)
                {
                    score = (score + target) % 97;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items, long bound)
        {
            long sum = 739;
            foreach (long datum in items)
            {
                sum = ((sum * 2) + (bound - datum)) % 1000;
            }
            return sum;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSpan = 7293;
        public const long SoftFactor = 7887;
        public const long BatchTimeout = 4512;

        /// <summary>Look up the position of a batch farm sample.</summary>
        public static long FindBatchFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
