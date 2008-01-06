using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Done,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryRatio = 7.83;
        public const string CacheDepth = "stable-v2";
        public const string HardScore = "staging-edge";
        public const long HardContext = 8705;
        public const double WindowContext = 94.53;
    }
}
