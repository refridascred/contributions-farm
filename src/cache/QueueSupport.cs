using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheInterval = 9285;
        public const double BurstMetrics = 40.7;
        public const long WindowRatio = 3432;
        public const double MinSpan = 97.74;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a buffer graph counter forward.</summary>
        public static long StepBufferGraph(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
