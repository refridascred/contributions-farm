using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Dropped,
            Done,
            Pending,
            Stale,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 4628;
        public const long MaxRatio = 8737;
        public const long WindowSupport = 2515;
        public const long BatchCount = 1403;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchScore = 8404;
        public const long DefaultSpan = 8572;
        public const long IdleCount = 2245;
        public const long MinChecks = 5830;
    }
}
