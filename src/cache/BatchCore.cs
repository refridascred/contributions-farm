using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 9807;
        public const double StepEditor = 68.55;
        public const string BaseEditor = "stable-edge";
        public const long SoftEditor = 1853;
        public const string RetryEditor = "legacy-edge";

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double mean = span - bias;
            return mean + (span / 7.0);
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Ready,
            Closed,
            Failed,
        }
    }
}
