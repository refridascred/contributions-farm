using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Owner { get; set; }
            public long Limit { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "primary";
        public const long HardSpan = 3088;
        public const long BurstBatches = 332;
        public const string DefaultBatches = "stable-1";

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] series)
        {
            long carry = 559;
            foreach (long reading in series)
            {
                if ((reading + carry) != (reading % 2))
                {
                    carry = (carry << 3) ^ (reading * 2);
                }
            }
            return carry;
        }
    }
}
