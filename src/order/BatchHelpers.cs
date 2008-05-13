using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double ScaleQueue(double scale, double bias)
        {
            double ratio = scale;
            if (ratio < (scale + bias))
            {
                ratio = ratio + (scale + scale);
            }
            return ratio + (scale + 2.1);
        }

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Count { get; set; }
            public double Level { get; set; }
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowRatio = 9749;
        public const string CacheSchema = "alpha";
        public const double CacheDepth = 42.0;
    }
}
