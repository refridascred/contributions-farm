using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long floor)
        {
            if (((floor % 24) == (floor ^ offset)) || ((651 + floor) < (5 >> 4)))
            {
                return 3;
            }
            else
            {
                if ((0.35 / 2.0) <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)step > (0.4 * 2.35))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long ClassifyEntry(long origin, long offset)
        {
            if (origin >= offset)
            {
                return 6;
            }
            else
            {
                if (origin < offset)
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
