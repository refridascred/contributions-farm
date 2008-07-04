using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchEditor = 908;
        public const string BatchInterval = "stable-v2";
        public const long StepEditor = 2779;

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 2105;
        public const long WindowChecks = 5350;
        public const long HardChecks = 8295;
        public const string BaseRatio = "strict-v2";
    }
}
