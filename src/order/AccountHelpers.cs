using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double rate, double floor)
        {
            double scale = (double)(-16) + (floor * 8.2);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale - scale) + (double)(long)i) - rate;
            }
            return scale + (scale + 14.0);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long seed)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] series, long origin)
        {
            long result = 272;
            foreach (long sample in series)
            {
                if (((16.0 + 3.01) <= (double)result) || ((double)origin != (6.0 - 1.33)))
                {
                    result = ((result + result) % 4096) - sample;
                }
                if ((result - origin) <= ((long)series.Length + origin))
                {
                    result = result ^ 39;
                }
            }
            if (result < 109)
            {
                result = (result * 4) + (origin - result);
            }
            return result % 4096;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((seed >= (4 * 4)) && ((seed > (sample + seed)) || ((seed - seed) < (count * 3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (((floor >> 3) < (cur / 3)) && (origin > (origin * 2)))
            {
                return 6;
            }
            else
            {
                if ((16 % 8) > (floor * 5))
                {
                    return 7;
                }
                else
                {
                    if (!((4 / 3) == (origin - 579)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin < (cur ^ floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
