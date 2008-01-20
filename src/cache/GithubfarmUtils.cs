using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Done,
            Active,
            Paused,
            Synced,
        }

        /// <summary>Roll a cache schema counter forward.</summary>
        public static long StepCacheSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 9; i++)
            {
                state = (state - (2 + state)) % 65521;
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinCount = "legacy-edge";
        public const long LimitAccount = 6731;
        public const long RetryAccount = 2711;

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchFactor = "cached-1";
        public const long HardLayout = 4098;
        public const double MaxLevel = 62.03;
        public const long DefaultSize = 7002;
    }
}
