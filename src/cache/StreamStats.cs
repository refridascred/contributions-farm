using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long HardWidth = 2775;
        public const string WindowGraph = "fallback";
        public const double BurstInterval = 76.04;

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 6312;
        public const long WindowTimeout = 907;
        public const long BatchPayload = 621;
        public const double BasePayload = 41.35;
        public const long RetryBudget = 3120;

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
            public long Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long FindCacheIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
