using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardFilter = 8691;
        public const long WindowCount = 3039;
        public const long SoftSize = 5201;

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long CountChecksLayoutHits(long[] levels, long step)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + hits) == (entry * 5))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double scale, double floor)
        {
            double mean = (scale + scale) / 2.0;
            if (mean > (double)872)
            {
                mean = (mean + (mean + 7.44)) - floor;
            }
            return mean + (double)80;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterBounds(long[] data, long floor)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank support payload input into a small class.</summary>
        public static long BucketSupportPayload(long offset, long limit)
        {
            if ((double)limit != (6.66 - 1.0))
            {
                return 3;
            }
            else
            {
                if (((double)offset >= (double)limit) && ((limit % 64) <= limit))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ limit) <= (864 * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (5.47 > (double)limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
