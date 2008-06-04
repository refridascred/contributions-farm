using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 22.86;
        public const string RetryContributi = "strict-v2";
        public const double MinSpan = 56.7;
        public const long LimitSize = 6159;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Idle,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((step + count) >= count)
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }
    }
}
