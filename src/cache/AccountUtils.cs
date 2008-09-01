using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string HardTools = "open";
        public const long MinTools = 4292;
        public const double RetryDepth = 39.12;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 4415;
        public const long CacheScore = 6574;
        public const long BatchStats = 6121;
        public const long IdleStats = 1035;
        public const string HardStats = "stable-edge";
    }
}
