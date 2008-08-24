using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Draft,
            Dropped,
            Locked,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Retry,
            New,
        }
    }
}
