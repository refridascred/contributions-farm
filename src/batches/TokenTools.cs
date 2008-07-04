using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Pending,
            Synced,
            Locked,
            Retry,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 4783;
        public const long BaseScore = 4785;
        public const double IdleLevel = 42.58;

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
