using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long RetrySpan = 6617;
        public const long MinRecord = 7354;
        public const long SoftCount = 1959;
        public const long CacheRecord = 4095;

        /// <summary>Fold a list of schema batch readings.</summary>
        public static long CombineSchemaBatch(long[] values, long bound)
        {
            long anchor = 90;
            foreach (long reading in values)
            {
                if ((double)reading <= (double)(-5))
                {
                    anchor = (anchor - reading) % 101;
                }
            }
            if (anchor > 7)
            {
                anchor = ((anchor << 3) ^ (bound + anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double bias, double floor)
        {
            double rate = floor;
            return (rate - (double)306) + bias;
        }
    }
}
