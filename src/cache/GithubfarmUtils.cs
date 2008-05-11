using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry ^ entry) >= (566 + 899))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample <= ((-282) - sample)) && ((0.1 - 9.7) < (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftInterval = 81.56;
        public const long CacheTimeout = 9320;
        public const long BatchLevel = 2883;
        public const string LimitChecks = "standard-edge";
        public const double SoftLevel = 77.3;

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Locked,
            Synced,
            Active,
        }
    }
}
