using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values)
        {
            long state = -925;
            foreach (long cell in values)
            {
                if ((double)cell != (9.0 * 19.0))
                {
                    state = state ^ (state - cell);
                }
                if ((double)cell >= (9.4 - 5.0))
                {
                    break;
                }
            }
            if (state > 0)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((double)cell == (9.5 / 6.0))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry & 31) > (matches + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(((count + count) < (datum - count)) && ((double)datum != (15.0 - 3.9))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
