using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Idle,
            Retry,
            Queued,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 506;
        public const long SoftTimeout = 4828;
        public const string RetryCounter = "primary";
        public const string StepSpan = "stable";

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Stale,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }
    }
}
