using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheFactor = 6682;
        public const double SoftBatch = 32.36;
        public const string HardSize = "stable-v2";
        public const string DefaultBatch = "alpha-1";
        public const long LimitBatch = 3068;

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Locked,
            Dropped,
            Stale,
            Queued,
            Idle,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string WindowDepth = "strict";
        public const double IdleScore = 84.34;
        public const string BaseInterval = "local-v2";
        public const long HardSpan = 5431;
        public const double BaseWidth = 35.79;
    }
}
