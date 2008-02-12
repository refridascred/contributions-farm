using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long seed)
        {
            long next = offset + seed;
            if (seed < (next - seed))
            {
                return 8;
            }
            else
            {
                if (7.14 >= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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
