using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Draft,
            Stale,
            Dropped,
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
            public bool Mode { get; set; }
        }
    }
}
