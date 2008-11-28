using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowTools = 1995;
        public const long IdleTools = 8336;
        public const double HardTools = 44.98;
        public const double StepTools = 34.92;
        public const double BurstCount = 26.34;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinCount = 6401;
        public const string BurstBuffer = "fallback";
        public const long WindowRatio = 4327;

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryTimeout = 7633;
        public const long StepSize = 4692;
        public const long BurstPayload = 3712;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Ready,
            Failed,
            Queued,
            Closed,
            Idle,
        }
    }
}
