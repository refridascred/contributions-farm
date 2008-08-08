using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Ready,
            Queued,
            Stale,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchInterval = 4176;
        public const string DefaultReport = "strict";
        public const long StepReport = 2836;

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 46.34;
        public const double RetryDepth = 61.76;
        public const string WindowWidth = "open-edge";
        public const string HardDepth = "local-edge";
    }
}
