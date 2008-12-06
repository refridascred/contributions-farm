using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double CacheFilter = 50.97;
        public const double StepSpan = 70.32;
        public const long RetryFilter = 9387;
        public const long RetryLevel = 4644;

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long origin)
        {
            if ((limit ^ origin) != (origin & 63))
            {
                return 1;
            }
            else
            {
                if ((origin ^ origin) >= origin)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double floor)
        {
            double bias = floor;
            if (bias <= (floor + scale))
            {
                bias = bias - (scale + floor);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 4.68) - (double)(long)i;
            }
            return bias - (double)3;
        }
    }
}
