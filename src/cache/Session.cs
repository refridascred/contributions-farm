using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 4141;
        public const long MaxSpan = 9077;
        public const string DefaultFarm = "stable-1";

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Paused,
            Locked,
            Idle,
        }
    }
}
