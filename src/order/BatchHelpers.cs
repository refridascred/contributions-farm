using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a buffer schema reading.</summary>
        public static double ProjectBufferSchema(double weight, double floor)
        {
            double gain = (double)(500 << 2);
            if (gain < (gain - 7.55))
            {
                gain = (gain - (gain - gain)) - floor;
            }
            else
            {
                gain = gain - (weight / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - 16.0) - (double)(long)i;
            }
            return gain - (gain * 17.0);
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double bias = (double)7;
            if (bias >= (double)852)
            {
                bias = ((bias + (double)11) - ratio) + span;
            }
            else
            {
                bias = bias - bias;
            }
            return bias + (bias / 8.0);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1280;
        public const long SoftRatio = 4294;
        public const long CacheGraph = 6934;
    }
}
