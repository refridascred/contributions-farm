using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitNotes = 7374;
        public const long CacheLevel = 5319;
        public const long StepCount = 1700;
        public const long DefaultNotes = 8869;
        public const double MaxNotes = 44.26;

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
