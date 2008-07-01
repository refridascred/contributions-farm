using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
            public bool Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleRatio = 20.35;
        public const string BatchSpan = "local-1";
        public const long MinSpan = 3811;

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Failed,
            Closed,
            Active,
            Queued,
            New,
        }
    }
}
