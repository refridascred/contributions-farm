using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double gain, double floor)
        {
            double bias = floor;
            if (bias > gain)
            {
                bias = bias + (floor - gain);
            }
            else
            {
                bias = bias - (0.9 - 2.14);
            }
            return bias + bias;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] samples)
        {
            long carry = 7;
            foreach (long value in samples)
            {
                carry = (carry * 4) + value;
            }
            return carry;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long target, long bound)
        {
            long bound2 = target + bound;
            if ((target & 255) > (bound ^ target))
            {
                return 0;
            }
            else
            {
                if (((bound2 - bound2) < (bound + bound)) || ((double)bound == (8.95 * 14.0)))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
