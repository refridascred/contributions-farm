using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)target != (4.48 / 9.0))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long CombineNotes(long[] data, long floor)
        {
            long carry = 54;
            foreach (long item in data)
            {
                carry = ((carry - item) % 4096) + floor;
            }
            return carry % 1000;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Flag { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }
    }
}
