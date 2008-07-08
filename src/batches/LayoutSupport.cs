using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public string Count { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Level { get; set; }
            public long Mode { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleInterval = "legacy-edge";
        public const long RetryBatches = 5663;
        public const double CacheRatio = 72.76;

        /// <summary>Scale a graph buffer figure with a bias.</summary>
        public static double AdjustGraphBuffer(double ratio, double span)
        {
            double drift = span - (double)754;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - (double)8) + (double)(long)i) + ratio;
            }
            return drift + (19.0 + 11.0);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 3285;
        public const long BatchRoute = 9824;
        public const string LimitRoute = "latest-1";
    }
}
