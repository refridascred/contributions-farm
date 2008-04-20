using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long SoftToken = 1943;
        public const long RetryToken = 5585;
        public const long HardToken = 791;
        public const long DefaultToken = 5492;
        public const long WindowToken = 5199;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark * 2) + mark) % 4096;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double bias, double span)
        {
            double mean = 2.1 / 4.0;
            if (mean < (double)(-182))
            {
                mean = (mean + (bias / 3.0)) + span;
            }
            else
            {
                mean = mean - (double)4;
            }
            return mean + bias;
        }
    }
}
