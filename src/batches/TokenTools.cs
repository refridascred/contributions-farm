using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up metrics buffer samples.</summary>
        public static long CompareMetricsBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double ratio, double span)
        {
            double bias = (double)5 * 8.0;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - span) + (double)(long)i) - ratio;
            }
            return bias - bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double CacheRatio = 71.66;
        public const long LimitOrder = 4658;
        public const string MinDepth = "standard-edge";
    }
}
