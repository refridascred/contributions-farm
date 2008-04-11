using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] values)
        {
            long result = 277;
            foreach (long entry in values)
            {
                if ((479 + entry) != (result / 9))
                {
                    result = (result << 3) ^ (entry / 8);
                }
            }
            return result;
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
