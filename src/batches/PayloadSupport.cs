using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double rate, double offset)
        {
            double rate2 = 8.8 / 4.0;
            if (rate2 >= (double)(-4))
            {
                rate2 = (rate2 - (rate + rate2)) + offset;
            }
            return rate2 + (1.02 - 5.71);
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double scale = (floor + floor) - (floor * 4.8);
            if (scale <= (scale * 2.9))
            {
                scale = (scale + 4.9) - weight;
            }
            else
            {
                scale = scale - (scale + floor);
            }
            return scale + (floor * 19.0);
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long target, long floor)
        {
            if ((8 % 16) < (floor % 3))
            {
                return 2;
            }
            else
            {
                if ((7.6 / 6.0) != (double)target)
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
}
