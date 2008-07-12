using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            New,
            Queued,
            Stale,
            Locked,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardDepth = 1667;
        public const double RetryCluster = 20.38;
        public const double BurstInterval = 82.92;

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
