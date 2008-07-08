using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinGithubfarm = "latest";
        public const string BurstCount = "standard";
        public const string StepGithubfarm = "primary";
        public const string RetryWidth = "legacy-1";
        public const long BurstFactor = 231;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Draft,
            Failed,
            Locked,
            Queued,
            Retry,
        }
    }
}
