using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheInterval = 2331;
        public const long SoftBatch = 741;
        public const long RetryBatch = 8462;
        public const long MaxLevel = 1324;

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BurstContributi = "open-v2";
        public const string IdleContributi = "local";
        public const string BaseContributi = "primary-v2";
        public const double BaseInterval = 65.87;
        public const string BatchRatio = "stable-edge";

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = (result * 4) + result;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
