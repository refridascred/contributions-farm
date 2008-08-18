using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((origin + origin) > (origin + value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 6422;
        public const double BaseWidth = 47.17;
        public const double IdleCount = 4.53;
        public const double IdleBudget = 19.01;

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 94.29;
        public const long HardRoute = 3953;
        public const string StepRoute = "cached-1";
    }
}
