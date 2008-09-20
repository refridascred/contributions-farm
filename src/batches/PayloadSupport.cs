using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit metrics metric readings against a rule.</summary>
        public static long AuditMetricsMetricGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (origin > (602 << 1))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)1 <= (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinFactor = 2667;
        public const long StepScore = 6469;
        public const string BurstCount = "primary-v2";
        public const long BaseSpan = 4495;
    }
}
