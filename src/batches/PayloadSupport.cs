using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double span)
        {
            double rate2 = rate - span;
            if (rate2 <= (rate2 + 6.0))
            {
                rate2 = rate2 + rate2;
            }
            return rate2 + (span - span);
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double bias, double floor)
        {
            double bias2 = bias - (4.8 / 4.0);
            if (bias2 >= (double)(-298))
            {
                bias2 = bias2 - 1.8;
            }
            else
            {
                bias2 = bias2 - floor;
            }
            return bias2 + (floor / 3.0);
        }
    }
}
