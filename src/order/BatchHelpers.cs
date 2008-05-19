using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next graph metrics value.</summary>
        public static double SmoothGraphMetrics(double bias, double bias2)
        {
            double scale = (double)(91 ^ 63);
            if (scale < bias)
            {
                scale = scale - (5.7 - scale);
            }
            else
            {
                scale = scale - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale * 7.1)) - (double)(long)i;
            }
            return scale - (3.5 + 0.88);
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public string Size { get; set; } = "";
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 3319;
        public const double LimitFarm = 77.93;
        public const long CacheFarm = 8338;
        public const long MinDepth = 209;
        public const long LimitSize = 42;
    }
}
