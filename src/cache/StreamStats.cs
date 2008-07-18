using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double CacheReport = 66.84;
        public const long SoftLevel = 2038;
        public const string DefaultReport = "cached-1";
        public const double MinReport = 38.13;
        public const long WindowReport = 1285;

        /// <summary>Audit batches profile readings against a rule.</summary>
        public static long AuditBatchesProfileMatches(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((7.9 / 5.0) > (double)cell)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((64 << 3) <= (tally + bound))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }
    }
}
