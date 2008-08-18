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

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxLevel = 6219;
        public const double BatchNotes = 12.74;
        public const string BatchRatio = "legacy-edge";

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 94.29;
        public const long HardRoute = 3953;
        public const string StepRoute = "cached-1";
    }
}
