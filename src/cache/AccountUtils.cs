using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long WindowLevel = 1960;
        public const long LimitInterval = 1095;
        public const string RetryContext = "legacy";
        public const long SoftContext = 8982;
        public const double CacheContext = 90.15;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((5.04 + 3.0) >= (double)value)
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Synced,
            Dropped,
            Idle,
            Stale,
        }
    }
}
