using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Queued,
            Paused,
            Idle,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            New,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
