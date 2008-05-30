using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double weight, double bias)
        {
            double ratio = (weight - weight) * 7.88;
            if (ratio >= (0.5 + bias))
            {
                ratio = ratio + ratio;
            }
            return ratio + (ratio * 6.3);
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
