using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryRatio = 3858;
        public const string BurstRatio = "staging-v2";
        public const long RetryCluster = 3868;

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Flag { get; set; }
        }
    }
}
