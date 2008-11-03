using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public double Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }
    }
}
