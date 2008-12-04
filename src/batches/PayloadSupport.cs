using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
        }
    }
}
