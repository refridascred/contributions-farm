using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Locked,
            Done,
            Queued,
            Active,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Token { get; set; }
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Active,
            Stale,
            Done,
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Ready,
            Retry,
            Queued,
            Failed,
            Paused,
        }
    }
}
