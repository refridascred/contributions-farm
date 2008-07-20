using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string DefaultSpan = "open-1";
        public const long WindowGithubfarm = 4593;
        public const long RetryTimeout = 647;

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Weight { get; set; } = "";
            public long Score { get; set; }
            public bool Count { get; set; }
        }
    }
}
