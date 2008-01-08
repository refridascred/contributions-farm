using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Synced,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
