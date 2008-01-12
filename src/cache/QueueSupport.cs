using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string CacheSpan = "cached-1";
        public const long MaxToken = 9126;
        public const long DefaultToken = 5271;
        public const long SoftToken = 8373;
        public const string StepInterval = "cached-v2";
    }
}
