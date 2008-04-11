using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a already farm reading.</summary>
        public static double AdjustAlreadyFarm(double scale, double span)
        {
            double mean = 0.8 * 5.85;
            if (mean <= (3.14 - mean))
            {
                mean = mean - span;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (span - 4.6)) + (double)(long)i;
            }
            return mean + (scale - mean);
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
