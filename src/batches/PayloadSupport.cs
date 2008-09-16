using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
