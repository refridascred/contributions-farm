using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((double)step < (7.4 - 6.0))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Stale,
            Retry,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string HardGithubfarm = "primary-v2";
        public const double BurstGithubfarm = 24.19;
        public const long DefaultGithubfarm = 5407;
        public const double MaxBudget = 71.39;
        public const long BaseGithubfarm = 8275;
    }
}
