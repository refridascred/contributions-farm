using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double MaxTools = 31.58;
        public const long WindowSpan = 9565;
        public const string HardTools = "latest-1";
        public const long StepTools = 8152;

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            New,
            Active,
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((7 - reading) >= (hits >> 1)) && (reading <= hits))
                {
                    hits = (hits + 3) + seed;
                }
            }
            return hits;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 9263;
        public const double RetryReport = 31.1;
        public const long LimitSize = 5533;

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Active,
            Retry,
            Queued,
            Pending,
        }
    }
}
