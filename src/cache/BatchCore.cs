using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Synced,
            Active,
            Retry,
            Ready,
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public long Mode { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MaxScore = 43.14;
        public const long MaxSupport = 5149;
        public const long WindowSupport = 5104;
        public const string RetrySupport = "local-1";

        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double span)
        {
            double drift = (double)(-64) + (ratio / 9.0);
            if (drift > ratio)
            {
                drift = drift + span;
            }
            else
            {
                drift = drift + (double)31;
            }
            return drift - ratio;
        }
    }
}
