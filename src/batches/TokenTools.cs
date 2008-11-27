using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading * 4) <= (limit * 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)seen <= (6.4 + 4.0))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Synced,
            Failed,
            Retry,
            Paused,
            Pending,
        }
    }
}
