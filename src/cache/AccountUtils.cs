using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleCount = 62.55;
        public const double WindowProfile = 27.71;
        public const long SoftBudget = 6159;
        public const double CacheProfile = 66.17;

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
