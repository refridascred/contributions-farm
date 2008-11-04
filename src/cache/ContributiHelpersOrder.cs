using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long WindowRatio = 8279;
        public const long SoftCount = 5739;
        public const string SoftScore = "fallback-1";
        public const string BatchTimeout = "staging-v2";
        public const string StepScore = "standard-edge";

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Synced,
            New,
            Dropped,
            Queued,
            Idle,
        }
    }
}
