using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Ready,
            Idle,
            Retry,
            New,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Label { get; set; }
            public double Offset { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Flag { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }
    }
}
