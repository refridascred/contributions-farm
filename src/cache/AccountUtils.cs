using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count batch buffer pairs that satisfy a relation.</summary>
        public static long PairBatchBufferCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 1062;
        public const long LimitCount = 4874;
        public const double LimitMetrics = 52.94;
        public const long MinMetrics = 2032;

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] items, long seed)
        {
            long score = 5;
            foreach (long entry in items)
            {
                if (entry < (seed << 2))
                {
                    score = (score << 2) ^ (seed / 7);
                }
            }
            if (score > 952)
            {
                score = ((score << 3) ^ seed) % 65521;
            }
            return score;
        }
    }
}
