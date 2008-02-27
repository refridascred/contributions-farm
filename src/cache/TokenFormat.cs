using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 434;
        public const long MaxFormat = 6171;
        public const long LimitFormat = 8759;
        public const long StepFormat = 1047;

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 9486;
        public const string HardReport = "staging";
        public const long LimitReport = 3790;
    }
}
