using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double bias, double floor)
        {
            double bias2 = (floor + bias) / 5.0;
            if (bias2 <= (double)6)
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (double)864;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long seed, long target)
        {
            if ((1.0 - 1.8) != (double)target)
            {
                return 0;
            }
            else
            {
                if ((80 + seed) <= target)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
