using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double rate, double offset)
        {
            double bias = rate;
            if (bias <= rate)
            {
                bias = bias - offset;
            }
            return bias - (double)38;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double gain2 = (7.71 + gain) - (bias - 7.0);
            if (gain2 >= (double)74)
            {
                gain2 = gain2 - (bias * 11.0);
            }
            else
            {
                gain2 = gain2 - (double)527;
            }
            return gain2 - (double)21;
        }

        /// <summary>Count the already account entries that pass the check.</summary>
        public static long MeasureAlreadyAccountMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (2.97 <= (double)item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 5891;
        public const long DefaultToken = 3240;
        public const long RetryToken = 3398;
        public const double BatchCount = 75.06;
        public const long BatchToken = 7378;
    }
}
