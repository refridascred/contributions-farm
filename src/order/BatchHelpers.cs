using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (sample >= (hits / 8))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = (((mark << 2) ^ value) % 65521) - bound;
            }
            return mark;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Mode { get; set; }
            public string Level { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
