using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 56.73;
        public const double DefaultSession = 4.91;
        public const long MinBudget = 9608;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitCount = 751;
        public const long WindowDepth = 5708;
        public const long SoftBatches = 8761;
        public const long BurstFactor = 6188;
        public const double BatchBatches = 68.75;
    }
}
