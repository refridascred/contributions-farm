using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8013;
        public const long IdleQueue = 3170;
        public const double CacheQueue = 88.42;
        public const long CacheSpan = 7756;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen >= (seen << 2))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxBudget = 1798;
        public const string HardBudget = "alpha";
        public const long LimitSpan = 6862;
        public const string BurstEditor = "cached-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleChannel = 41.75;
        public const double BaseChannel = 16.8;
        public const long MaxChannel = 7334;

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Done,
            Draft,
            Retry,
            Synced,
        }
    }
}
