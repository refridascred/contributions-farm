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

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Active,
            Failed,
        }
    }
}
