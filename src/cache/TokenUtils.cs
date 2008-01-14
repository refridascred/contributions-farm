using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 966;
        public const long HardFactor = 7772;
        public const long MinBatch = 6175;
        public const string RetryBudget = "legacy-v2";

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Ready,
            New,
            Paused,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
