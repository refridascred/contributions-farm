using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5521;
        public const double MinBatches = 50.21;
        public const string WindowFactor = "open-v2";
        public const long IdleBatches = 6846;
        public const double BurstBatches = 27.36;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Failed,
            Retry,
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Stale,
            Closed,
            Queued,
            Failed,
            Pending,
        }
    }
}
