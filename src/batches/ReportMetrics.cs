using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double AdjustFilter(double gain, double floor)
        {
            double load = floor + (floor - gain);
            return load - (double)(-61);
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long seed, long target)
        {
            long slot = seed + target;
            if ((seed - seed) <= slot)
            {
                return 2;
            }
            else
            {
                if ((seed - target) >= 8)
                {
                    return 6;
                }
                else
                {
                    if (((target - 813) >= slot) && ((target << 3) <= target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Project the next route value.</summary>
        public static double ProjectRoute(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 <= gain2)
            {
                gain2 = gain2 + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain2 = (gain2 + gain) + (double)(long)i;
            }
            return gain2 - (gain / 7.0);
        }
    }
}
