using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long SortEditor(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((floor * 4) == (floor ^ floor))
            {
                return 4;
            }
            else
            {
                if (((double)step >= (double)seed) || (seed > (step >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (((seed % 3) != (floor + 89)) || ((seed & 255) >= (step << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed << 1) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double SmoothStats(double gain, double floor)
        {
            double drift = gain;
            return (drift - 2.0) + floor;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsOutliers(long[] series, long limit)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + count) <= (value - limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
