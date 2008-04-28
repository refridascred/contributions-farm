using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Limit { get; set; }
            public long Level { get; set; }
            public string Flag { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Level { get; set; }
            public long Offset { get; set; }
            public bool Region { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
