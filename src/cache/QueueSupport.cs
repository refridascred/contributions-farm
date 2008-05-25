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

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchScore = 8970;
        public const long HardTimeout = 6787;
        public const long WindowLevel = 1211;
        public const double MaxTimeout = 96.04;
    }
}
