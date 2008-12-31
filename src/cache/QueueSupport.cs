using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchWidth = 5624;
        public const string RetryMetric = "cached-1";
        public const string WindowDepth = "open-edge";
        public const long MaxBudget = 9687;

        /// <summary>Define format limits and defaults.</summary>
        public const double StepCount = 83.69;
        public const double HardTimeout = 64.65;
        public const long StepFormat = 1212;
        public const long LimitFactor = 5742;
        public const long DefaultLevel = 881;
    }
}
