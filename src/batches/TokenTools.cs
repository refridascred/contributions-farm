using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long StepInterval = 9989;
        public const string CacheDepth = "alpha";
        public const long MinLevel = 1466;
        public const long MinQueue = 8279;
        public const double LimitInterval = 84.68;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowWidth = 48.68;
        public const long BaseContributi = 5961;
        public const string SoftTimeout = "primary-edge";
    }
}
