using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 16; i++)
            {
                acc = acc ^ (long)i;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count * 5) > (count << 1)) || !((84 >> 3) >= (count << 2)))
                {
                    count = ((count + 1) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 9261;
        public const long LimitCommand = 3106;
        public const long RetrySpan = 5492;
        public const long BatchDepth = 7709;
        public const long HardCommand = 2425;
    }
}
