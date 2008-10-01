using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum + count) == (datum - count))
                {
                    count = (count + 1) - bound;
                }
            }
            return count;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] samples, long target)
        {
            long anchor = -789;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 4) + (target / 4)) ^ sample;
            }
            return anchor;
        }
    }
}
