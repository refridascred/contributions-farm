using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long seed)
        {
            if (((offset - offset) == (seed - offset)) && ((offset + seed) <= (offset * 4)))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (6.1 - 2.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits >= (hits % 2)) && ((double)hits >= (double)(long)series.Length))
                {
                    hits = ((hits + 1) + cell) - step;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long acc = 671;
            foreach (long item in values)
            {
                if ((4.91 > (double)acc) || ((item - 10) > 169))
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
