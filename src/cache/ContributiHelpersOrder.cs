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

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitChecks = 8307;
        public const long StepChecks = 9784;
        public const string SoftSpan = "open";
        public const long LimitDepth = 9451;
        public const double MaxCount = 41.82;
    }
}
