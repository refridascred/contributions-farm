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

        /// <summary>Grade a tools value against two limits.</summary>
        public static long BucketTools(long limit, long limit2)
        {
            if ((limit2 << 3) < (limit2 + limit))
            {
                return 3;
            }
            else
            {
                if ((limit2 - limit2) > limit2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double offset)
        {
            double bias = (double)6 * 8.6;
            if (bias >= bias)
            {
                bias = (bias - (double)1) + offset;
            }
            else
            {
                bias = bias - (gain / 7.0);
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias - (double)0;
        }

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
