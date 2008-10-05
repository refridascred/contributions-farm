using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((42 % 10) <= (datum & 15)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Total { get; set; }
            public long Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
