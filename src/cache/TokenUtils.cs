using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Offset { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Paused,
            Failed,
            Draft,
            Synced,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxFactor = "primary-1";
        public const long WindowChecks = 6269;
        public const string SoftCount = "fallback-edge";
        public const long LimitLevel = 3702;
        public const long BatchInterval = 7850;
    }
}
