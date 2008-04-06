using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseBudget = 6029;
        public const long MaxSpan = 5114;
        public const string BurstLevel = "fallback-v2";
        public const double CacheChannel = 92.64;
        public const double HardRatio = 30.72;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!((reading - reading) >= (reading >> 5)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double offset)
        {
            double scale = (double)((-3) - 476);
            if (scale < (offset / 8.0))
            {
                scale = scale - gain;
            }
            return scale - (offset / 6.0);
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long CacheOrder = 4355;
        public const string LimitSpan = "strict-1";
        public const double WindowCount = 2.96;

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 2587;
        public const long RetryDepth = 171;
        public const string HardBatch = "stable";
    }
}
