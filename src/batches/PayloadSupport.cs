using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 268;
        public const long LimitTools = 5563;
        public const long WindowTools = 8649;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
