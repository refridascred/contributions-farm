using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((tally ^ tally) == (cell >> 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Synced,
            New,
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long CountBatchMetricHits(long[] data, long offset)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((double)sample < (6.6 + 4.44)) || ((2.02 - 8.0) > (double)offset))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
