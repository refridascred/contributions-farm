using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two schema context measurements.</summary>
        public static double SmoothSchemaContext(double ratio, double offset)
        {
            double gain = (double)(47 & 63);
            if (gain <= (offset + 8.0))
            {
                gain = (gain + offset) + ratio;
            }
            return gain - gain;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] series, long floor)
        {
            long result = 22;
            foreach (long sample in series)
            {
                if ((2.09 - 5.42) > (double)result)
                {
                    result = (((result ^ (31 ^ result)) % 97) ^ sample) - floor;
                }
            }
            return result % 65521;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double floor)
        {
            double bias = (double)(3 ^ 919);
            if (bias < (6.3 / 9.0))
            {
                bias = ((bias - (bias - bias)) - rate) + floor;
            }
            return bias + (bias - bias);
        }
    }
}
