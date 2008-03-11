using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Region { get; set; }
            public long Token { get; set; }
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
