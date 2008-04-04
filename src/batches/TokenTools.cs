using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardSize = 6.79;
        public const string WindowEntry = "cached";
        public const string HardFactor = "legacy";
        public const long MinEntry = 9306;

        /// <summary>Define record limits and defaults.</summary>
        public const long RetryRecord = 6366;
        public const long CacheRecord = 3885;
        public const long BaseTimeout = 3272;
        public const long SoftRecord = 9695;
        public const long WindowLevel = 6843;

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long target, long origin)
        {
            if (!((target / 8) <= (target - origin)))
            {
                return 4;
            }
            else
            {
                if ((target << 2) < target)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
