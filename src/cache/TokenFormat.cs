using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 3431;
        public const double BatchCount = 74.26;
        public const double SoftBudget = 84.69;
        public const string CacheSession = "local-v2";
        public const long HardSession = 7001;

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowRatio = 6.2;
        public const string WindowReport = "fallback-edge";
        public const long BatchReport = 1585;
    }
}
