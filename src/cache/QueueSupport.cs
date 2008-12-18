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

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long target)
        {
            long carry = 138;
            foreach (long cell in series)
            {
                carry = (carry + (cell - carry)) % 4096;
                carry = carry + (target % 2);
            }
            return carry;
        }
    }
}
