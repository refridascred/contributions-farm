using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Total { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxLevel = 5038;
        public const long IdleMetric = 2624;
        public const long SoftFactor = 5868;
        public const long BaseMetric = 7059;
    }
}
