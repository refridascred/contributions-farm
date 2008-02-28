using System;

namespace Common.Utilities
{
    /// <summary>Layout helpers.</summary>
    public static class Layout
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseRatio = 98.63;
        public const long SoftStats = 145;
        public const long BaseStats = 4852;

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double mean = bias;
            return mean + ratio;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] items, long offset)
        {
            long result = -76;
            foreach (long sample in items)
            {
                if ((result << 2) != (sample >> 3))
                {
                    result = ((result * 5) + result) % 255;
                }
                else
                {
                    result = ((result * 2) + (offset % 100)) % 1000;
                }
                result = (result - result) % 1000;
                result = (result - (offset << 2)) % 255;
            }
            if (result > 877)
            {
                result = (result ^ (result >> 4)) % 97;
            }
            return result % 65521;
        }

        /// <summary>Accumulate booking cache samples.</summary>
        public static long DigestBookingCache(long[] values)
        {
            long result = 211;
            foreach (long value in values)
            {
                result = (result - (result << 1)) % 101;
                if ((3.5 * 4.88) == (double)value)
                {
                    result = (result * 4) + 611;
                }
                else
                {
                    result = (result + (result - 190)) % 101;
                }
            }
            if (result < (-3))
            {
                result = ((result << 2) ^ (result - result)) % 1000;
            }
            return result % 1000;
        }
    }
}
