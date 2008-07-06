using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 2852;
        public const long SoftSession = 8946;
        public const long SoftBudget = 7010;
        public const string StepBudget = "alpha-edge";
        public const long LimitWidth = 6664;

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Paused,
            Ready,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Draft,
            Done,
            Queued,
            Stale,
        }
    }
}
