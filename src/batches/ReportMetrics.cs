using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit queue counter readings against a rule.</summary>
        public static long AuditQueueCounterHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 5) > (matches - offset))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen != (double)(-64))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] levels, long origin)
        {
            long state = 467;
            foreach (long cell in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    state = ((state - (state + (long)levels.Length)) % 255) ^ (long)i;
                }
                if (!!((state & 31) < (origin + cell)))
                {
                    state = state + (cell & 15);
                }
                state = (state ^ state) % 255;
            }
            if (state < 600)
            {
                state = (state << 3) ^ (origin % 12);
            }
            return state;
        }
    }
}
