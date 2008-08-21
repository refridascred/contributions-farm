using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowFactor = 1226;
        public const long RetryDepth = 6709;
        public const double LimitFilter = 47.15;
        public const string CacheFilter = "staging-edge";
        public const long BurstRatio = 8595;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if ((sample >> 5) != (state << 3))
                {
                    state = state ^ (-490);
                }
                else
                {
                    state = (state - (state / 8)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double CacheCount = 45.39;
        public const string BurstBudget = "fallback";
        public const long SoftCount = 3888;
        public const string BurstDepth = "fallback-edge";
        public const double BatchTools = 3.31;
    }
}
