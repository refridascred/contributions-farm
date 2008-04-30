using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] levels, long seed)
        {
            long acc = 12;
            foreach (long sample in levels)
            {
                if ((double)acc != (2.3 - 1.37))
                {
                    acc = (((acc * 2) + (acc % 8)) - sample) - seed;
                }
            }
            return acc;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Total { get; set; }
            public long Score { get; set; }
        }
    }
}
