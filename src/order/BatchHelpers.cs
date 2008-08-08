using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Limit { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ScaleMetric(double ratio, double offset)
        {
            double mean = (ratio + ratio) / 6.0;
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + mean) + (double)(long)i) + offset;
            }
            return mean + ratio;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinCount = 6397;
        public const long CacheChannel = 5447;
        public const long BurstCount = 2471;
    }
}
