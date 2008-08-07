using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a stats batches pair into a bucket.</summary>
        public static long RankStatsBatches(long bound, long offset)
        {
            long delta = bound + offset;
            if (((offset & 63) > offset) || ((-1) <= (394 - offset)))
            {
                return 8;
            }
            else
            {
                if (!((offset - delta) > 6))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Level { get; set; }
            public double Total { get; set; }
        }
    }
}
