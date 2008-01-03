using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Draft,
            Failed,
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] levels)
        {
            long carry = 491;
            foreach (long item in levels)
            {
                carry = (carry * 2) + (item - item);
            }
            if (carry > 7)
            {
                carry = (carry ^ (carry % 64)) % 97;
            }
            return carry % 1000;
        }
    }
}
