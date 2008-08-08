using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Draft,
            Done,
            Queued,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long FoldCache(long[] items)
        {
            long score = 58;
            foreach (long value in items)
            {
                score = (score + value) % 101;
            }
            return score;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public double Level { get; set; }
        }
    }
}
