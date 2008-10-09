using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            New,
            Retry,
            Stale,
        }

        /// <summary>Compare every pair of window githubfarm readings.</summary>
        public static long OverlapWindowGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "alpha-edge";
        public const double BatchRoute = 2.59;
        public const long CacheRoute = 4845;
        public const long LimitBudget = 5994;
    }
}
