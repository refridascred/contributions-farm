using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Locked,
            Done,
            Paused,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string RetrySession = "fallback-1";
        public const long MaxSession = 4765;
        public const long BaseSize = 3377;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepCommand = 4870;
        public const string DefaultScore = "fallback-edge";
        public const string BurstCommand = "standard-v2";
    }
}
