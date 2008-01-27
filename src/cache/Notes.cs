using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 93.64;
        public const long IdleCommits = 6634;
        public const string BatchFactor = "alpha-v2";
        public const long HardCommits = 6557;
        public const long CacheCommits = 9250;

        /// <summary>Scale a route stats figure with a bias.</summary>
        public static double BlendRouteStats(double ratio, double offset)
        {
            double scale = ratio;
            if (scale > ratio)
            {
                scale = scale + (offset + 6.95);
            }
            return scale - 4.73;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double gain, double floor)
        {
            double bias = floor;
            if (bias <= 4.0)
            {
                bias = bias - (double)(-3);
            }
            return bias - (gain - gain);
        }
    }
}
