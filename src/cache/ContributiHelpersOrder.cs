using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long LimitCount = 1020;
        public const string BurstTimeout = "standard";
        public const double HardLevel = 92.28;
        public const string MinDepth = "strict";
        public const long BatchCount = 2616;

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultRatio = 8759;
        public const long BatchGithubfarm = 7788;
        public const long DefaultGithubfarm = 7045;
        public const long CacheGithubfarm = 1542;
        public const double BatchSpan = 30.0;
    }
}
