using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - seed) >= (seed + 717))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchSize = 6385;
        public const long StepScore = 4240;
        public const long BatchScore = 8699;
        public const double RetryRatio = 29.88;
    }
}
