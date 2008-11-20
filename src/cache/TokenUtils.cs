using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double LimitCount = 97.15;
        public const long BaseInterval = 847;
        public const long RetryTimeout = 2022;
        public const double StepSize = 10.27;

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double scale, double span)
        {
            double bias = span / 2.0;
            if (bias < span)
            {
                bias = (bias - span) - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (double)3) + (double)(long)i;
            }
            return bias - 3.46;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long seed, long seed2)
        {
            if (seed2 <= (1 % 5))
            {
                return 7;
            }
            else
            {
                if ((double)seed2 > (0.99 * 3.23))
                {
                    return 8;
                }
                else
                {
                    if (((seed2 ^ 506) < (seed ^ seed2)) && ((872 + 81) > (seed - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
