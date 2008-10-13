using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Token { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Ready,
            Paused,
            Idle,
            Failed,
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public double Offset { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
            public double Token { get; set; }
        }
    }
}
