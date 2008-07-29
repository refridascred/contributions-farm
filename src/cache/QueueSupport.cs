using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Offset { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardDepth = "open-v2";
        public const long MinSpan = 7946;
        public const long MaxBatch = 7865;

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long target, long offset)
        {
            if ((offset - offset) >= 4)
            {
                return 3;
            }
            else
            {
                if ((4.8 + 3.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
