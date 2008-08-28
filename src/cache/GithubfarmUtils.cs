using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitFactor = 6056;
        public const long MinSize = 517;
        public const long HardChecks = 2847;
        public const long DefaultChecks = 6522;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Ready,
            Stale,
            Paused,
            Active,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((offset <= 1) || ((0.61 + 6.68) >= (double)item))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string StepOrder = "latest-v2";
        public const string HardOrder = "alpha-1";
        public const double WindowInterval = 44.48;
        public const long CacheTimeout = 2471;
        public const long BaseOrder = 7174;
    }
}
