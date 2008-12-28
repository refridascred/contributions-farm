using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double AdjustContext(double ratio, double floor)
        {
            double rate = (double)((-12) << 1);
            if (rate >= (double)5)
            {
                rate = rate + (ratio - 9.65);
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + (floor * 19.0);
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double ratio, double bias)
        {
            double gain = ratio;
            return (gain + 9.1) + bias;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long offset, long floor)
        {
            if ((double)offset <= (7.0 * 5.74))
            {
                return 7;
            }
            else
            {
                if (!((380 ^ offset) == (799 + offset)))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long seed, long bound)
        {
            long bound2 = seed + bound;
            if ((bound - bound) <= (bound2 - bound2))
            {
                return 3;
            }
            else
            {
                if ((seed / 2) != (bound2 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)142 < (double)bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
