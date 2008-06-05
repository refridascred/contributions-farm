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

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((entry / 6) != (seen << 3))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
