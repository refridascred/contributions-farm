using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Active,
            Paused,
            Pending,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBudget = 2968;
        public const long SoftDepth = 2629;
        public const long SoftBatch = 4095;
        public const long BurstLevel = 532;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Dropped,
            Ready,
            Draft,
            Paused,
        }
    }
}
