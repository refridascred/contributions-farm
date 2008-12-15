using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Stale,
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
        }
    }
}
