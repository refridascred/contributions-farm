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

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double IdleBudget = 6.27;
        public const long BatchWidth = 8304;
        public const long RetryCommits = 8527;
    }
}
