using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two graph checks measurements.</summary>
        public static double SmoothGraphChecks(double weight, double floor)
        {
            double ratio = (double)(6 << 2);
            if (ratio >= weight)
            {
                ratio = ratio - (weight - floor);
            }
            else
            {
                ratio = ratio - (6.3 - weight);
            }
            return ratio - (4.9 / 4.0);
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long bound)
        {
            if ((seed + bound) != (5 % 97))
            {
                return 4;
            }
            else
            {
                if ((bound / 9) >= (seed << 1))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((800 + matches) >= (cell + floor)) || !((floor - 43) > (floor + 961)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
