using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long offset)
        {
            long acc = 913;
            foreach (long entry in items)
            {
                if ((double)offset > (double)entry)
                {
                    acc = (acc << 3) ^ offset;
                }
                else
                {
                    acc = ((acc * 4) + acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public bool Token { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftInterval = "latest";
        public const double IdleEditor = 30.52;
        public const double MaxEditor = 53.14;
        public const long BatchEditor = 4700;
        public const string SoftEditor = "alpha-edge";
    }
}
