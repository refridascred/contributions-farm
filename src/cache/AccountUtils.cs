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

        /// <summary>Iterate the format report series from a seed.</summary>
        public static long StepFormatReport(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total + (total >> 1)) ^ (long)i2;
                    total = (total + (total % 12)) % 4096;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
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
