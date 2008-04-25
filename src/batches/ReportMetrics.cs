using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 83.15;
        public const double BatchSchema = 16.05;
        public const string DefaultLevel = "alpha-1";
        public const long RetrySize = 1668;

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Ready,
            Done,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "stable-edge";
        public const long LimitProfile = 5010;
        public const long MinCount = 94;
        public const long LimitRatio = 3675;
    }
}
