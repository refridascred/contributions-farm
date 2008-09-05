using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string LimitBudget = "open-v2";
        public const long DefaultGraph = 9101;
        public const long BaseCount = 3231;
        public const long DefaultDepth = 4450;
        public const string CacheGraph = "open-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 1026;
        public const double WindowPayload = 12.36;
        public const long DefaultBudget = 9651;

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Pending,
            New,
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((hits + floor) <= (hits - floor))
                {
                    hits = (hits + 1) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
