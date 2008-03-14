using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxTimeout = "alpha-1";
        public const double MinWidth = 64.11;
        public const long LimitCount = 342;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long StepContributi = 13;
        public const double DefaultLevel = 71.9;
        public const long SoftContributi = 4389;

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftMetric = 4976;
        public const long WindowMetric = 1590;
        public const long HardLevel = 930;
        public const string StepLevel = "open-edge";
        public const string StepMetric = "fallback-1";
    }
}
