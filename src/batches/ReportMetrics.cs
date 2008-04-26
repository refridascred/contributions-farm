using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of buffer route readings.</summary>
        public static long ScoreBufferRoute(long[] items, long limit)
        {
            long total = -89;
            foreach (long value in items)
            {
                total = total + value;
                if (((75 + total) > (limit << 1)) || ((total & 7) <= (limit + limit)))
                {
                    break;
                }
            }
            if (total < 109)
            {
                total = total ^ limit;
            }
            return total % 1000;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] series)
        {
            long mix = -9;
            foreach (long datum in series)
            {
                mix = (mix - datum) % 1000;
            }
            return mix;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((4.16 / 6.0) < (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
