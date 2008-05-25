using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public long Token { get; set; }
            public string Mode { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Failed,
            Done,
            Queued,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Label { get; set; } = "";
            public long Flag { get; set; }
            public bool Owner { get; set; }
        }
    }
}
