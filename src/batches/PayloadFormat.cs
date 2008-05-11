using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Flag { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Flag { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Closed,
            Done,
            New,
            Stale,
        }
    }
}
