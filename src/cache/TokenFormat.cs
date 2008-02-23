using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long MinSize = 481;
        public const long StepFarm = 2009;
        public const long IdleFactor = 1317;
        public const string BurstFarm = "fallback-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardTimeout = "open-1";
        public const long BatchTimeout = 8578;
        public const double BatchContributi = 33.91;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Draft,
            Ready,
            Done,
            Paused,
        }
    }
}
