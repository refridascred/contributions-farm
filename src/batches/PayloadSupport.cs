using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MaxSession = "local-1";
        public const long RetrySession = 2344;
        public const long StepTimeout = 8830;
        public const long CacheSession = 6516;
        public const string BurstFactor = "legacy-1";

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Active,
            Ready,
            Locked,
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
