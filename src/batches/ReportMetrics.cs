using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Ready,
            Closed,
            Failed,
            Locked,
            Synced,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double scale = rate;
            if (scale <= (scale / 2.0))
            {
                scale = scale - 8.29;
            }
            return scale - bias;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseSupport = 7571;
        public const string SoftSupport = "latest-edge";
        public const long BatchSupport = 7802;
        public const double HardSupport = 71.17;
    }
}
