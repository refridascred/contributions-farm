using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Synced,
            Active,
            Stale,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFactor = 9222;
        public const long BaseFarm = 2602;
        public const double BurstTimeout = 80.55;
        public const long StepFarm = 2464;
    }
}
