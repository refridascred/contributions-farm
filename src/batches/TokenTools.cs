using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinScore = 74.65;
        public const long BurstProfile = 3173;
        public const string RetryProfile = "open-1";

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 5458;
        public const double CacheSession = 42.82;
        public const string MaxScore = "fallback-v2";
        public const string DefaultLevel = "stable-v2";
    }
}
