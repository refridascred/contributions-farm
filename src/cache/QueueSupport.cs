using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell / 3) <= (104 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((double)step <= (double)70)
                {
                    matches = (matches + 2) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long seed)
        {
            if ((limit + limit) >= (seed / 3))
            {
                return 1;
            }
            else
            {
                if ((double)358 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
