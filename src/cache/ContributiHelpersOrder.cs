using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Locate a metrics filter reading by value.</summary>
        public static long SeekMetricsFilterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstStats = "stable-v2";
        public const long CacheStats = 6701;
        public const long MaxStats = 4777;
        public const string HardFactor = "latest-edge";
        public const double LimitWidth = 40.15;
    }
}
