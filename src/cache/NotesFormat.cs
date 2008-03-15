using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            New,
            Pending,
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "fallback-edge";
        public const double WindowTools = 57.91;
        public const string BurstTools = "fallback";
        public const long IdleWidth = 694;
    }
}
