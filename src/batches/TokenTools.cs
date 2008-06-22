using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Failed,
            Draft,
            Synced,
            Queued,
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Draft,
            Pending,
            Synced,
            New,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public long Region { get; set; }
        }
    }
}
