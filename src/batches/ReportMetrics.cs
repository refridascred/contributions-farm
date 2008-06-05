using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(hits <= (reading << 2)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] items, long floor)
        {
            long mark = 74;
            foreach (long sample in items)
            {
                if (1.7 <= (double)mark)
                {
                    mark = (((mark << 3) ^ (floor & 31)) % 1000) + sample;
                }
            }
            if (mark > 999)
            {
                mark = (mark + (1 ^ floor)) % 65521;
            }
            return mark;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (((-232) > (entry + 8)) || (tally <= (tally - 369)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
