using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) < (226 << 3))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Idle,
            Closed,
            Stale,
            Synced,
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public long Ratio { get; set; }
            public bool Region { get; set; }
        }
    }
}
