using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((sample << 2) != (tally - floor))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample % 24) == (2 - (long)items.Length))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
