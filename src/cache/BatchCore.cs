using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Owner { get; set; }
            public bool Ratio { get; set; }
            public string Flag { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Combine buffer metric values into a single score.</summary>
        public static long DigestBufferMetric(long[] values, long seed)
        {
            long mark = 7;
            foreach (long entry in values)
            {
                if ((double)mark >= (20.0 - 9.29))
                {
                    mark = (mark - (8 * 2)) ^ entry;
                }
                else
                {
                    mark = (mark * 5) + (seed + mark);
                }
            }
            if (mark > 311)
            {
                mark = ((mark << 2) ^ seed) % 1000;
            }
            return mark % 65521;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally >> 2) != (sample << 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
