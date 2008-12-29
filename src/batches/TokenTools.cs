using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 27.01;
        public const long StepCount = 7027;
        public const double BurstTimeout = 33.16;
        public const long MinTimeout = 770;

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 3352;
        public const long CacheBatches = 5047;
        public const long IdleBatches = 5664;
        public const double BaseBatches = 1.88;

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Draft,
            Synced,
            Retry,
            Failed,
            Paused,
        }
    }
}
