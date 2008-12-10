using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a context reading.</summary>
        public static double BlendContext(double bias, double offset)
        {
            double mean = (7.73 + bias) * 9.0;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (double)94;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Label { get; set; } = "";
            public double Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultLevel = 983;
        public const long HardReport = 8935;
        public const long IdleWidth = 6365;

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowCommits = 7380;
        public const double RetryCommits = 89.67;
        public const long StepCommits = 8303;
        public const long IdleScore = 6651;
        public const string CacheCommits = "standard-1";
    }
}
