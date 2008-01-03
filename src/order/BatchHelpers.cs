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

        /// <summary>Grade a entry metrics value against two limits.</summary>
        public static long ClassifyEntryMetrics(long bound, long seed)
        {
            if (bound <= (bound + seed))
            {
                return 6;
            }
            else
            {
                if (!((bound & 1) <= (28 % 64)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + bound) != (95 ^ seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((824 ^ bound) > (bound >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
