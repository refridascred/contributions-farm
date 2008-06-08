using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double mean = scale;
            if (mean < scale)
            {
                mean = (mean + mean) - floor;
            }
            return mean - (mean / 7.0);
        }

        /// <summary>Project the next token value.</summary>
        public static double SmoothToken(double rate, double bias)
        {
            double gain = bias;
            return (gain - bias) + rate;
        }
    }
}
