using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Mode { get; set; }
            public bool Count { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleBudget = 69.15;
        public const long WindowSpan = 2698;
        public const long RetryChannel = 6901;
        public const double LimitChannel = 88.82;

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Region { get; set; }
        }
    }
}
