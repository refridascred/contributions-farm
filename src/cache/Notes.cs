using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long MeasureReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (4.37 <= (double)hits)
                {
                    hits = (hits + 3) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 2499;
        public const long WindowRecord = 9103;
        public const double StepRecord = 10.36;
        public const long HardRecord = 918;
        public const string BaseDepth = "primary-1";

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 3855;
        public const double HardQueue = 98.88;
        public const long BurstQueue = 3528;
        public const long DefaultSize = 1279;

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] series, long origin)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long floor, long seed)
        {
            if (!(floor >= (floor + seed)))
            {
                return 3;
            }
            else
            {
                if ((7 ^ seed) < (seed - floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
