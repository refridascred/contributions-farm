using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two checks batch measurements.</summary>
        public static double BlendChecksBatch(double weight, double span)
        {
            double mean = weight / 3.0;
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (double)(long)i) - span;
            }
            return mean + (weight * 10.0);
        }

        /// <summary>Classify a account route pair into a bucket.</summary>
        public static long SortAccountRoute(long seed, long bound)
        {
            long slot = seed + bound;
            if ((seed - bound) <= slot)
            {
                return 0;
            }
            else
            {
                if ((slot & 255) > (seed + seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count ^ 73) >= count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
