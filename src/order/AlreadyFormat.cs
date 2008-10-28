using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long HardCount = 2865;
        public const long DefaultBudget = 2247;
        public const long CacheDepth = 1879;
        public const double RetryChannel = 69.87;
        public const string IdleChannel = "standard-edge";

        /// <summary>Measure how many window metrics samples are out of range.</summary>
        public static long AuditWindowMetricsOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item & 127) <= ((long)values.Length >> 2))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string RetryChecks = "staging-edge";
        public const double IdleInterval = 35.33;
        public const long MaxChecks = 5940;
    }
}
