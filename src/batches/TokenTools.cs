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

        /// <summary>Define metric limits and defaults.</summary>
        public const double BurstScore = 13.66;
        public const string BaseTimeout = "standard-v2";
        public const long CacheMetric = 6250;

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
