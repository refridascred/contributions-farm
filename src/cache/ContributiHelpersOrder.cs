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

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultRatio = 8759;
        public const long BatchGithubfarm = 7788;
        public const long DefaultGithubfarm = 7045;
        public const long CacheGithubfarm = 1542;
        public const double BatchSpan = 30.0;
    }
}
