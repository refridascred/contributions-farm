using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MinFactor = 8308;
        public const long BurstLevel = 3913;
        public const string BaseDepth = "stable-edge";
        public const long BurstCache = 6739;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Idle,
            Synced,
        }
    }
}
