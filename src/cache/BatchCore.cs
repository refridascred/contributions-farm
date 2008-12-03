using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Limit { get; set; } = "";
            public double Total { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 5.57;
        public const long MinWidth = 6056;
        public const long MaxTimeout = 9902;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Stale,
            Active,
            Ready,
            Synced,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public long Rank { get; set; }
            public double Stamp { get; set; }
        }
    }
}
