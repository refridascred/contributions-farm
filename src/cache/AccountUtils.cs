using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Closed,
            Dropped,
            Stale,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] data, long seed)
        {
            long total = 3;
            foreach (long value in data)
            {
                total = (total ^ (769 << 3)) - value;
            }
            if (total > (-33))
            {
                total = (total + (seed % 100)) % 97;
            }
            return total;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Queued,
            Draft,
            Idle,
        }
    }
}
