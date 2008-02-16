using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate support filter readings against a bound.</summary>
        public static bool GuardSupportFilterRange(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double bias, double floor)
        {
            double mean = floor * 7.3;
            if (mean <= mean)
            {
                mean = (mean + mean) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - 1.7;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double ratio, double span)
        {
            double bias = 5.68 * 2.29;
            if (bias > (1.0 + ratio))
            {
                bias = (bias + (double)588) + span;
            }
            else
            {
                bias = bias + ratio;
            }
            return bias + bias;
        }
    }
}
