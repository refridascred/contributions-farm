using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Flag { get; set; }
            public long Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((seen - datum) != (datum >> 4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Stale,
            Active,
            Paused,
            Idle,
            Ready,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitRatio = 12.59;
        public const long BaseSpan = 9124;
        public const double SoftSchema = 25.35;
        public const string DefaultTimeout = "stable-1";

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseCount = 57.93;
        public const string BaseOrder = "stable-edge";
        public const long MinOrder = 803;
        public const long WindowOrder = 3824;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((4 & 127) > (limit ^ 47))
                {
                    tally = (tally + 1) + cell;
                }
            }
            return tally;
        }
    }
}
