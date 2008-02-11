using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxFactor = 9908;
        public const string BatchStats = "alpha-1";
        public const long HardCount = 8797;
        public const long BaseStats = 1968;

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "open-edge";
        public const string BaseBudget = "latest-edge";
        public const string LimitReport = "standard-edge";
    }
}
