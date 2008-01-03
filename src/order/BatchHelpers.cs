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

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Active,
            Draft,
            Queued,
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
