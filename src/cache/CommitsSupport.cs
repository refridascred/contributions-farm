using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepTimeout = 8942;
        public const long RetryBudget = 7541;
        public const long BaseReport = 4082;
        public const long LimitReport = 7813;

        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheDepth = 2.82;
        public const double BaseFactor = 55.15;
        public const long WindowWidth = 4798;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LookupOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
