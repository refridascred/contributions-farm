using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Done,
            Ready,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public bool Score { get; set; }
            public bool Size { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Active,
            Failed,
            Synced,
            Paused,
            Stale,
        }
    }
}
