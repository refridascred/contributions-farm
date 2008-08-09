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

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionHits(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (seen < (seen & 63))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
