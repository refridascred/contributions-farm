using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a queue batches reading.</summary>
        public static double ProjectQueueBatches(double ratio, double floor)
        {
            double gain = 18.0;
            return (gain + (floor * 5.1)) + ratio;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Closed,
            Pending,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Token { get; set; }
            public bool Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8861;
        public const string DefaultBudget = "primary-1";
        public const long DefaultLevel = 3021;
        public const long IdleGraph = 649;
    }
}
