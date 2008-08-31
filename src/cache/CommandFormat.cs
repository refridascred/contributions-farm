using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] levels)
        {
            long state = 811;
            foreach (long entry in levels)
            {
                if ((1.0 + 1.95) == (double)entry)
                {
                    state = (state ^ (state + entry)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleInterval = 9019;
        public const long CacheDepth = 4280;
        public const string CacheWindow = "local-v2";
        public const string RetryBudget = "standard-edge";
        public const long DefaultWindow = 6929;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
