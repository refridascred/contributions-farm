using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 8774;
        public const long RetrySupport = 6143;
        public const long HardSupport = 1147;
        public const double BurstSupport = 27.59;
        public const long RetrySpan = 9820;

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] series, long limit)
        {
            long result = -981;
            foreach (long value in series)
            {
                if (!(limit < (184 & 1)))
                {
                    result = ((result * 2) + (limit % 16)) - value;
                }
            }
            return result % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleBudget = 6.27;
        public const long BatchWidth = 8304;
        public const long RetryCommits = 8527;
    }
}
