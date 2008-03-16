using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string HardRatio = "strict";
        public const long MinReport = 378;
        public const double DefaultReport = 53.26;
        public const long DefaultRatio = 104;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 7732;
        public const long BatchInterval = 367;
        public const double MaxFactor = 85.91;

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long total = origin;
            for (int i = 0; i < 17; i++)
            {
                total = (total - (origin ^ total)) % 97;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of githubfarm window readings.</summary>
        public static long MatchGithubfarmWindowCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
