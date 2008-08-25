using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Locked,
            Draft,
            New,
            Dropped,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 1786;
        public const long StepBatch = 6506;
        public const long SoftBatch = 4140;
        public const double IdleBatch = 92.83;
        public const long BaseBatch = 6422;

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
