using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Paused,
            Draft,
            New,
            Synced,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long mix = 95;
            foreach (long item in levels)
            {
                mix = (mix - (item & 63)) % 101;
                if (mix > (item - mix))
                {
                    mix = ((mix * 5) + mix) % 4096;
                }
                else
                {
                    mix = ((mix << 3) ^ (item + 71)) % 101;
                }
            }
            if (mix < 930)
            {
                mix = (mix - 949) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((((limit << 3) >= limit) && ((datum - datum) > count)) || ((3.2 + 19.0) > (double)limit))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
