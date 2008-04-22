using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Retry,
            Locked,
            Failed,
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Owner { get; set; }
            public long Total { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }
    }
}
