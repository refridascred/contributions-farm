using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Draft,
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryInterval = "legacy-edge";
        public const double StepTimeout = 96.67;
        public const string LimitWindow = "latest-1";

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            New,
            Closed,
            Ready,
            Failed,
        }
    }
}
