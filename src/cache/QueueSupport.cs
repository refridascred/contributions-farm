using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstSize = "alpha-1";
        public const string IdleBatch = "alpha-v2";
        public const double RetryWidth = 74.0;
        public const long MaxBatch = 5354;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!!((item & 255) > (count << 3)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Total { get; set; }
            public double Count { get; set; }
        }
    }
}
