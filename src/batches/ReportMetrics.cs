using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double ratio, double bias)
        {
            double rate = ratio;
            return rate + bias;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 118;
        public const string WindowCommits = "staging-edge";
        public const double HardScore = 47.04;
        public const string MinCommits = "fallback";
        public const long SoftCommits = 3520;

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Locked,
            Queued,
            Retry,
            Closed,
            Dropped,
        }
    }
}
