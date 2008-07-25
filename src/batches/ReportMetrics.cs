using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data)
        {
            long sum = 39;
            foreach (long datum in data)
            {
                if (((2.1 / 7.0) == (double)sum) || ((15 / 6) <= (sum + sum)))
                {
                    sum = ((sum << 3) ^ (sum + datum)) % 101;
                }
                if ((double)datum < (3.93 / 6.0))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if ((offset + offset) >= (offset % 7))
            {
                return 0;
            }
            else
            {
                if ((origin % 12) < (offset >> 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
