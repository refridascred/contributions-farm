using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Synced,
            Done,
            Draft,
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Queued,
            Failed,
            Active,
            Dropped,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileMatches(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits >= (4 + reading))
                {
                    hits = (hits + 3) + origin;
                }
            }
            return hits;
        }
    }
}
