using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BatchMetric = "standard-v2";
        public const long BaseMetric = 9298;
        public const long StepMetric = 4502;
        public const long CacheRatio = 8137;
        public const double MaxBudget = 55.72;

        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 87.35;
        public const long HardSpan = 2067;
        public const long StepChecks = 4424;
    }
}
