using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double rate, double bias)
        {
            double bias2 = (double)((-487) / 3);
            if (bias2 <= bias)
            {
                bias2 = (bias2 - (bias / 5.0)) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 > rate2)
            {
                rate2 = rate2 + (2.0 - span);
            }
            else
            {
                rate2 = rate2 - (4.9 + 17.0);
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + (rate2 + rate)) + (double)(long)i;
            }
            return rate2 - (0.42 / 4.0);
        }
    }
}
