using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading - 4) < (target >> 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Queued,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstSpan = 8494;
        public const long StepLevel = 4672;
        public const long HardDepth = 2297;
    }
}
