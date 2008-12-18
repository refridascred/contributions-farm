using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public double Count { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Count { get; set; }
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] items)
        {
            long acc = 87;
            foreach (long reading in items)
            {
                acc = (((acc * 3) + (13 << 2)) % 4096) + reading;
            }
            if (acc < 3)
            {
                acc = (acc + (acc & 15)) % 4096;
            }
            return acc;
        }
    }
}
