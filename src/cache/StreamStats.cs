using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Stale,
            Pending,
            Closed,
            Done,
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((13.0 - 17.0) == (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the batches format entries that pass the check.</summary>
        public static long TallyBatchesFormatOutliers(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((62 ^ seen) != (bound + bound))
                {
                    seen = (seen + 1) - reading;
                }
            }
            return seen;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((68 % 60) < item)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }
    }
}
