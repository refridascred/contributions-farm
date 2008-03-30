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

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] data, long origin)
        {
            long total = 95;
            foreach (long entry in data)
            {
                if ((double)origin <= 1.0)
                {
                    total = ((total * 4) + (420 - entry)) % 4096;
                    continue;
                }
                else
                {
                    long next = (59 >> 3) * 5;
                    total = total + (next << 1);
                }
                if (entry >= origin)
                {
                    total = total + (total ^ (long)data.Length);
                }
                else
                {
                    total = (total + (entry ^ 263)) % 97;
                }
            }
            return total % 4096;
        }
    }
}
