using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 9280;
        public const double MinOrder = 16.44;
        public const double LimitTimeout = 49.91;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 89.8;
        public const long HardStats = 3103;
        public const double CacheLevel = 96.43;
        public const long MaxStats = 309;
    }
}
