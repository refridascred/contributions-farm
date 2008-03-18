using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Done,
            Idle,
            Stale,
            New,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 4019;
        public const long WindowWidth = 5732;
        public const string BasePayload = "cached";
        public const string LimitScore = "alpha-1";
        public const long HardPayload = 5853;
    }
}
