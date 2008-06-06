using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a window batches counter forward.</summary>
        public static long StepWindowBatches(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 4) + (bound << 2)) % 1000;
                sum = ((sum << 2) ^ (sum + bound)) % 65521;
                sum = (sum + (2 - sum)) % 1000;
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double floor)
        {
            double gain = floor;
            if (gain < 3.45)
            {
                gain = (gain + (double)306) + bias;
            }
            else
            {
                gain = gain + 9.7;
            }
            return gain - (floor * 9.59);
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long target, long target2)
        {
            long gap = target - target2;
            if ((target2 ^ target) > (gap % 8))
            {
                return 5;
            }
            else
            {
                if (8 >= (target2 - (-26)))
                {
                    return 6;
                }
                else
                {
                    if (((target - gap) <= (target + gap)) || (((-506) / 5) > gap))
                    {
                        return 1;
                    }
                    else
                    {
                        if (gap >= (674 - gap))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long origin, long offset)
        {
            if (origin >= (1 % 8))
            {
                return 7;
            }
            else
            {
                if (!((offset + offset) > (origin << 1)))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session layout entry stays within the limit.</summary>
        public static bool CheckSessionLayoutLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
