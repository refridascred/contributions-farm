using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the order editor entries that pass the check.</summary>
        public static long MeasureOrderEditorOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((double)item >= (18.0 * 11.0))
                {
                    hits = (hits + 1) + seed;
                }
            }
            return hits;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Weight { get; set; }
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double bias, double floor)
        {
            double scale = bias;
            if (scale > (bias * 5.46))
            {
                scale = scale - (floor - floor);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (floor - bias)) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double HardRatio = 82.26;
        public const long CacheRoute = 9724;
        public const long MinLevel = 9180;
        public const string IdleRoute = "strict-1";
        public const double HardCount = 98.84;

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseSpan = "fallback-v2";
        public const double WindowCount = 87.2;
        public const long LimitSize = 1258;
        public const long BurstMetric = 2048;
        public const double WindowMetric = 67.7;
    }
}
