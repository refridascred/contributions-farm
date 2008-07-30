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

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchProfile = 5830;
        public const long SoftInterval = 58;
        public const double MinProfile = 32.24;

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
