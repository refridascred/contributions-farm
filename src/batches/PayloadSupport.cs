using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Failed,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 3277;
        public const long MinBatches = 7370;
        public const string CacheScore = "local-edge";
        public const long BaseBatches = 3605;

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchTimeout = 3878;
        public const long LimitSession = 6084;
        public const long BurstSession = 8700;
        public const string StepTimeout = "staging-edge";
    }
}
