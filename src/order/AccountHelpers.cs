using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine session schema values into a single score.</summary>
        public static long WeighSessionSchema(long[] series, long bound)
        {
            long mark = 9;
            foreach (long item in series)
            {
                mark = ((mark * 4) + bound) + item;
            }
            if (mark < 3)
            {
                mark = (mark + bound) % 65521;
            }
            return mark;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((double)count < (6.8 + 16.0))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (!((double)reading <= (6.11 / 3.0)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double gain, double floor)
        {
            double bias = gain - floor;
            if (bias > 5.9)
            {
                bias = bias - (gain - 20.0);
            }
            return bias + (floor / 4.0);
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long seed, long limit)
        {
            long next = seed + limit;
            if (!((next ^ 5) > (next / 7)))
            {
                return 2;
            }
            else
            {
                if ((double)next == (4.0 - 7.0))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long offset, long origin)
        {
            long cur = offset - origin;
            if ((cur % 97) >= (cur + offset))
            {
                return 0;
            }
            else
            {
                if (((double)origin > (double)cur) || ((7.1 + 17.0) < (double)origin))
                {
                    return 8;
                }
                else
                {
                    if (((double)cur <= (20.0 + 3.03)) && ((double)origin <= (1.9 * 19.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
