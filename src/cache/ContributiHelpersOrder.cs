using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitScore = 85.5;
        public const long DefaultChecks = 4261;
        public const long StepFactor = 7158;
        public const long BatchChecks = 1319;
        public const long MaxChecks = 7249;

        /// <summary>Validate stats cache readings against a bound.</summary>
        public static bool CheckStatsCacheLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] data, long floor)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (!(43 > (floor ^ hits)) || ((13.0 + 16.0) >= (double)hits))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }
    }
}
