using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Draft,
            Done,
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Draft,
            Ready,
            Retry,
            New,
        }
    }
}
