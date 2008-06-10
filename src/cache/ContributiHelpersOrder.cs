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

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] values, long origin)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((matches % 2) < (matches ^ origin)))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
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
