using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mark = 2;
            foreach (long value in readings)
            {
                mark = (mark - mark) - value;
            }
            if (mark > 896)
            {
                mark = mark - (6 >> 5);
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftInterval = 8147;
        public const long IdleBudget = 896;
        public const long RetryReport = 5986;
        public const long WindowReport = 6265;
        public const long IdleReport = 9855;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits << 3) < 96))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
