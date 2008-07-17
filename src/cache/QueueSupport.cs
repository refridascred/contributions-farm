using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowDepth = 3388;
        public const string HardWidth = "primary-1";
        public const double HardMetric = 46.24;
        public const long StepScore = 5552;
        public const long BaseSpan = 9086;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Classify a schema payload pair into a bucket.</summary>
        public static long BucketSchemaPayload(long floor, long step)
        {
            if (((double)step == (8.8 / 2.0)) || ((3.5 * 20.0) >= (double)step))
            {
                return 0;
            }
            else
            {
                if ((double)step == (double)floor)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
