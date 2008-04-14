using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            New,
            Failed,
            Synced,
            Ready,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 14.18;
        public const long WindowTools = 752;
        public const long IdleScore = 542;
        public const double RetryTools = 68.51;
        public const long DefaultDepth = 8582;

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstInterval = "cached";
        public const long BaseChecks = 3909;
        public const long StepChecks = 6128;
        public const long WindowInterval = 241;
        public const double SoftChecks = 19.31;
    }
}
