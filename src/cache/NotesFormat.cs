using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double bias)
        {
            double mean = (scale * 6.3) + scale;
            if (mean < bias)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - 6.07;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 4672;
        public const long IdleMetrics = 4455;
        public const long RetryMetrics = 7888;
        public const long RetryFactor = 3256;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Ready,
            New,
            Retry,
        }
    }
}
