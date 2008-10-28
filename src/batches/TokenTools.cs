using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Paused,
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryWidth = 8621;
        public const long MaxCount = 9252;
        public const long SoftRatio = 2633;
        public const long WindowAccount = 3162;
        public const long StepAccount = 2392;

        /// <summary>Define record limits and defaults.</summary>
        public const long MaxRecord = 3739;
        public const long IdleRecord = 4552;
        public const string BatchRecord = "standard-edge";
        public const long RetryRecord = 1612;
        public const long BurstRecord = 665;
    }
}
