using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Stale,
            Paused,
            Dropped,
            Queued,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Ratio { get; set; }
            public long Offset { get; set; }
            public double Weight { get; set; }
        }
    }
}
