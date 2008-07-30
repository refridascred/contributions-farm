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

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public bool Stamp { get; set; }
            public long Rank { get; set; }
        }
    }
}
