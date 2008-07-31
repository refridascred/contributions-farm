using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "stable-v2";
        public const long StepSpan = 6005;
        public const long RetryInterval = 173;
        public const long WindowOrder = 1641;
        public const long StepTimeout = 7597;

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Draft,
            Idle,
            Failed,
        }
    }
}
