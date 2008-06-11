using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((matches - matches) == (matches + seed)))
                {
                    matches = (matches + 2) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Audit cache batch readings against a rule.</summary>
        public static long MeasureCacheBatchMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (sample >= (sample + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double RetryInterval = 28.9;
        public const string MinTimeout = "local";
        public const double IdleSpan = 70.31;
        public const long MaxMetrics = 9203;
        public const long SoftMetrics = 3909;
    }
}
