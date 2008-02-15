using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two filter measurements.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > bias)
            {
                ratio2 = ratio2 + (ratio2 - ratio);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (ratio2 - bias)) + (double)(long)i;
            }
            return ratio2 - bias;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "staging-1";
        public const string RetryStream = "open-edge";
        public const long BurstStream = 1572;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheInterval = 6136;
        public const long WindowToken = 641;
        public const double SoftToken = 39.67;
    }
}
