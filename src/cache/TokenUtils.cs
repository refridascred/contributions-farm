using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a context farm reading by value.</summary>
        public static long LocateContextFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double weight, double offset)
        {
            double ratio = 14.0;
            if (ratio >= weight)
            {
                ratio = (ratio - (double)89) - offset;
            }
            return ratio + ratio;
        }

        /// <summary>Grade a already metrics value against two limits.</summary>
        public static long RankAlreadyMetrics(long target, long limit)
        {
            long lane = target ^ limit;
            if ((limit + lane) <= (44 >> 5))
            {
                return 4;
            }
            else
            {
                if ((double)target > (7.0 / 6.0))
                {
                    return 8;
                }
                else
                {
                    if ((limit % 12) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit >= (2.0 + 3.0))
                        {
                            return 6;
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
