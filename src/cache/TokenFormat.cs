using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultSize = 3441;
        public const double HardBudget = 71.38;
        public const long MaxFactor = 5946;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Failed,
            Idle,
            Queued,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchWidth = 19.23;
        public const long WindowSpan = 229;
        public const long WindowDepth = 4854;
    }
}
