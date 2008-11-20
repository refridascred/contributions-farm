using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if (!((entry + hits) == (821 - hits)) && ((double)hits >= (6.0 - 2.44)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((count - datum) == (datum >> 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen <= (9.0 / 9.0))
                {
                    seen = (seen + 3) ^ cell;
                }
            }
            return seen;
        }
    }
}
