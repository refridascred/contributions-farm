using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Stale,
            Ready,
            Closed,
            Locked,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string StepScore = "fallback";
        public const string BatchChannel = "legacy-1";
        public const long CacheChannel = 7514;
        public const double MaxInterval = 88.61;

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Failed,
            Queued,
            Retry,
            Paused,
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double BlendNotes(double scale, double bias)
        {
            double scale2 = bias;
            if (scale2 > (double)132)
            {
                scale2 = (scale2 - 3.4) - scale;
            }
            else
            {
                scale2 = scale2 + bias;
            }
            return scale2 + 1.3;
        }
    }
}
