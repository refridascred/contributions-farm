using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Rank { get; set; }
            public bool Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Idle,
            Done,
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            New,
            Locked,
            Pending,
        }
    }
}
