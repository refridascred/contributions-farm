using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples)
        {
            long total = 106;
            foreach (long sample in samples)
            {
                if ((total - sample) != (sample % 60))
                {
                    total = (total * 5) + 9;
                }
            }
            return total % 65521;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Count { get; set; }
            public long Owner { get; set; }
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long HardSupport = 2528;
        public const long LimitScore = 3446;
        public const double BatchScore = 12.92;
        public const long MaxSupport = 5483;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count / 9) == (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBatch = 7854;
        public const double StepDepth = 56.69;
        public const long IdleBatch = 8202;
        public const long BurstBatch = 7708;
    }
}
