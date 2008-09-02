using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public bool Limit { get; set; }
            public double Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((67 - reading) != ((-67) - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 801;
        public const long RetryQueue = 9765;
        public const double MaxFactor = 77.9;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLevel = 5470;
        public const long BatchLayout = 8796;
        public const long MaxBudget = 5540;
        public const long IdleLayout = 2443;
        public const long WindowLayout = 1412;

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Pending,
            Idle,
            Closed,
            Retry,
        }
    }
}
