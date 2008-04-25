using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Queued,
            Paused,
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Active,
            Synced,
            Dropped,
            Queued,
        }
    }
}
