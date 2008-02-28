using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 7250;
        public const double IdleInterval = 36.63;
        public const long WindowSession = 3111;
        public const string MinDepth = "legacy-edge";

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleLevel = 19.8;
        public const long BaseInterval = 5857;
        public const string BaseSpan = "cached-1";
        public const long MinContext = 2680;
        public const double StepContext = 75.44;
    }
}
