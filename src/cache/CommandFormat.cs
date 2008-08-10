using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Synced,
            Locked,
            New,
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Dropped,
            Pending,
            Ready,
            New,
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double scale, double offset)
        {
            double weight = offset;
            if (weight > scale)
            {
                weight = weight + offset;
            }
            return weight - offset;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Ready,
            Queued,
        }
    }
}
