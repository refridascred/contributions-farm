using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Pending,
            Queued,
            Paused,
            Ready,
        }

        /// <summary>Combine checks order values into a single score.</summary>
        public static long WeighChecksOrder(long[] data)
        {
            long acc = 66;
            foreach (long sample in data)
            {
                if ((double)acc <= (7.02 - 2.98))
                {
                    acc = ((acc << 2) ^ (acc * 2)) % 255;
                }
                if ((acc * 5) < (acc - sample))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
