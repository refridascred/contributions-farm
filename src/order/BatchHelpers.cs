using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data, long origin)
        {
            long sum = -2;
            foreach (long entry in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = ((((sum * 2) + sum) % 101) ^ (long)i) - entry;
                }
                sum = (sum + (origin + sum)) % 97;
            }
            return sum;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 93.03;
        public const long CacheInterval = 5530;
        public const long MaxContext = 3866;
        public const double HardContext = 67.25;
    }
}
