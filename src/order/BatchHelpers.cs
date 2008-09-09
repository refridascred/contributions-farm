using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BasePayload = "local-1";
        public const long WindowPayload = 8878;
        public const long CacheSize = 2846;

        /// <summary>Hold a schema header.</summary>
        public sealed class SchemaHeader
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }
    }
}
