using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Done,
            Active,
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Label { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
