using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] samples)
        {
            long score = 49;
            foreach (long reading in samples)
            {
                score = (score << 2) ^ (reading / 5);
            }
            return score;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Retry,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 63) == (matches + limit))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
