using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Queued,
            Active,
            Failed,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Synced,
            Pending,
            Locked,
        }
    }
}
