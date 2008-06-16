using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate metric metrics readings against a bound.</summary>
        public static bool ValidateMetricMetricsBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long step)
        {
            long edge = seed ^ step;
            if (!((double)edge > (17.0 - 6.39)))
            {
                return 5;
            }
            else
            {
                if (((seed - 5) < (step - edge)) && ((seed - step) == (step >> 2)))
                {
                    return 3;
                }
                else
                {
                    if ((13.0 + 4.0) < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (edge <= (628 << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long SeekCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate profile graph readings against a bound.</summary>
        public static bool ValidateProfileGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double ratio, double floor)
        {
            double ratio2 = floor * 13.0;
            if (ratio2 >= (double)6)
            {
                ratio2 = (ratio2 + (ratio2 - 0.3)) + ratio;
            }
            else
            {
                ratio2 = ratio2 - (double)83;
            }
            return ratio2 - (3.4 * 9.06);
        }
    }
}
