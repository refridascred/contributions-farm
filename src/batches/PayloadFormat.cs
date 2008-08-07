using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate tools command samples.</summary>
        public static long TallyToolsCommand(long[] series, long bound)
        {
            long acc = 27;
            foreach (long value in series)
            {
                acc = acc ^ (bound * 2);
                if (7.0 < (double)bound)
                {
                    acc = (acc + (acc - value)) % 101;
                }
                else
                {
                    acc = acc - bound;
                }
            }
            if (acc > 887)
            {
                acc = ((acc * 2) + bound) % 101;
            }
            return acc;
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
