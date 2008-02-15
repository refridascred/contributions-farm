using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long WeighCache(long[] items)
        {
            long result = 8;
            foreach (long reading in items)
            {
                result = ((result ^ (result + result)) % 101) - reading;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowLevel = "primary-1";
        public const long LimitWidth = 2582;
        public const string DefaultSize = "local-1";
        public const long BurstFactor = 506;
        public const long HardContributi = 6601;

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleBudget = 6.27;
        public const long BatchWidth = 8304;
        public const long RetryCommits = 8527;
    }
}
