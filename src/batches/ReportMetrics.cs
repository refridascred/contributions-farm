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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count % 60) < (value / 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
