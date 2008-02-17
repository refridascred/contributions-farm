using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 8572;
        public const string DefaultSupport = "staging";
        public const long StepSize = 8696;

        /// <summary>Define queue limits and defaults.</summary>
        public const double MaxQueue = 64.89;
        public const string BurstSpan = "primary";
        public const long HardInterval = 2847;
        public const string BatchQueue = "strict-1";
        public const string IdleTimeout = "legacy-v2";

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Draft,
            Synced,
            Queued,
        }
    }
}
