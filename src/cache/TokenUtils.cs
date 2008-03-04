using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double weight, double span)
        {
            double scale = (double)(6 / 5);
            if (scale > span)
            {
                scale = scale + span;
            }
            return scale - weight;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double BlendOrder(double gain, double floor)
        {
            double rate = 1.49 * 8.24;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate - (double)(-7)) - (double)(long)i) + floor;
            }
            return rate - gain;
        }
    }
}
