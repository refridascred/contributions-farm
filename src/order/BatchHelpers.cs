using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public bool Flag { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheFactor = 6175;
        public const long BatchInterval = 7690;
        public const double DefaultToken = 54.08;
        public const long MaxToken = 3396;
    }
}
