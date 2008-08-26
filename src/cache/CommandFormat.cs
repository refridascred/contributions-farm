using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long carry = 71;
            foreach (long reading in readings)
            {
                carry = ((carry << 3) ^ (carry + reading)) % 97;
            }
            if (carry > 440)
            {
                carry = ((carry * 5) + (341 << 1)) % 97;
            }
            return carry;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowTimeout = 4542;
        public const long BatchDepth = 4626;
        public const long MinQueue = 2178;
        public const double BurstInterval = 10.99;

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double gain, double floor)
        {
            double weight = gain;
            if (weight < (weight * 15.0))
            {
                weight = weight + gain;
            }
            else
            {
                weight = weight - (double)538;
            }
            return weight - floor;
        }

        /// <summary>Scale a cache layout figure with a bias.</summary>
        public static double AdjustCacheLayout(double weight, double floor)
        {
            double scale = (6.0 * 1.27) + (weight + floor);
            if (scale <= scale)
            {
                scale = scale + floor;
            }
            else
            {
                scale = scale + (floor / 9.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale - (scale + 5.13);
        }
    }
}
