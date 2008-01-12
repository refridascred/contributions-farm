using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Failed,
            Stale,
            New,
            Ready,
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Failed,
            Active,
            Synced,
            Locked,
        }
    }
}
