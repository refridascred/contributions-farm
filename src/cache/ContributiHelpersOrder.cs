using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepRatio = 3867;
        public const double SoftContext = 53.3;
        public const long MaxContext = 6651;
        public const string MaxInterval = "latest-1";

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches - 561) != (3 ^ datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
