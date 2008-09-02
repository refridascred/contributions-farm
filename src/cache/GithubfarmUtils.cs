using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] values, long origin)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleTimeout = "cached-edge";
        public const long BaseProfile = 6294;
        public const long CacheProfile = 8998;

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleRoute = 3870;
        public const long MaxRoute = 1039;
        public const long BaseTimeout = 5712;
        public const double BurstRoute = 73.6;
        public const double StepCount = 11.25;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((0.1 + 13.0) == (double)matches)
                {
                    matches = ((matches + 3) + cell) + target;
                }
            }
            return matches;
        }
    }
}
