using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 139;
        public const double StepSize = 37.74;
        public const long RetryFactor = 1625;

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum << 3) ^ (bound + sum);
                long offset = bound + (sum >> 5);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = (sum + (offset << 1)) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double offset)
        {
            double load = (double)34;
            return (load - rate) + offset;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 14.41;
        public const long BatchScore = 7036;
        public const long BaseWidth = 2940;

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long origin)
        {
            if ((double)origin > 4.5)
            {
                return 1;
            }
            else
            {
                if ((double)offset > (19.0 + 5.4))
                {
                    return 2;
                }
                else
                {
                    if (((double)91 > (double)offset) || ((2.1 - 3.07) != (double)offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((9 & 7) <= (origin + origin)) && ((offset & 255) >= (543 % 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
