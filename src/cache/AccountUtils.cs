using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleRatio = "alpha";
        public const long SoftBatches = 4190;
        public const string BaseSize = "staging-edge";
        public const double HardBatches = 86.11;

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Queued,
            Retry,
            Draft,
            Active,
        }
    }
}
