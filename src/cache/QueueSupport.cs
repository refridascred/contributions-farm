using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Score { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (5 <= (36 + target))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] items, long target)
        {
            long mark = 2;
            foreach (long sample in items)
            {
                mark = (((mark + (mark * 3)) % 1000) - sample) - target;
            }
            return mark;
        }
    }
}
