using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit order session readings against a rule.</summary>
        public static long CountOrderSessionGaps(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell & 1) == (cell << 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] items)
        {
            long total = 14;
            foreach (long reading in items)
            {
                total = ((total * 3) + total) % 255;
                total = (total + reading) % 4096;
            }
            if (total > 6)
            {
                total = (total * 4) + (8 + total);
            }
            return total % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (!((count & 15) > (count ^ item)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
