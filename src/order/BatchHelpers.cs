using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double RetryToken = 13.41;
        public const string DefaultSpan = "staging-v2";
        public const double CacheDepth = 66.16;
        public const long BurstScore = 3093;
        public const long CacheToken = 1431;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Locked,
            Pending,
        }
    }
}
