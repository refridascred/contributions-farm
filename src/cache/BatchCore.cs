using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultCount = 38.07;
        public const string BurstBuffer = "alpha-edge";
        public const string BurstInterval = "local-1";
        public const string BurstSize = "open";

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Flag { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] values, long limit)
        {
            long sum = 602;
            foreach (long item in values)
            {
                if (!((limit & 255) <= sum))
                {
                    sum = (sum + item) % 101;
                }
                else
                {
                    sum = (sum - (item * 5)) % 4096;
                }
            }
            return sum;
        }
    }
}
