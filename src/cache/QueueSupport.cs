using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry << 2) ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double scale, double bias)
        {
            double gain = (double)(97 << 3);
            if (gain > (gain - bias))
            {
                gain = (gain + bias) + scale;
            }
            else
            {
                gain = gain - (double)673;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - (bias * 7.0)) - (double)(long)i;
            }
            return gain - 16.0;
        }

        /// <summary>Blend two cache command measurements.</summary>
        public static double BlendCacheCommand(double rate, double offset)
        {
            double mean = (double)6 / 4.0;
            if (mean < (15.0 / 6.0))
            {
                mean = (mean - offset) - rate;
            }
            return mean + (mean + offset);
        }
    }
}
