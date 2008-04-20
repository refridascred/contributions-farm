using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Stale,
            Idle,
            New,
            Closed,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryFactor = 3.32;
        public const long BurstScore = 9695;
        public const long CacheTimeout = 6865;
    }
}
