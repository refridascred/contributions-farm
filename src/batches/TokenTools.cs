using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Draft,
            Closed,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryBuffer = 86.92;
        public const long BaseWidth = 7236;
        public const long StepBuffer = 8800;
        public const string MinBuffer = "cached-v2";
        public const long RetryFactor = 9985;

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitScore = 187;
        public const long RetrySession = 7471;
        public const long RetryLevel = 5071;
    }
}
