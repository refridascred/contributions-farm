using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate batches commits readings against a bound.</summary>
        public static bool ValidateBatchesCommitsRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstMetric = "latest-v2";
        public const long RetryMetric = 4890;
        public const string MaxFactor = "alpha-v2";
        public const double StepDepth = 13.37;
        public const double WindowMetric = 79.19;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double RetryBudget = 29.37;
        public const double DefaultFactor = 69.3;
        public const long MinGithubfarm = 2159;
        public const string BatchGithubfarm = "fallback-edge";
    }
}
