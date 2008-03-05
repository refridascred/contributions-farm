using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Paused,
            Synced,
            Pending,
            Ready,
            Dropped,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading != (8.9 - 1.79))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long seed2)
        {
            if ((seed >> 5) > (seed2 * 3))
            {
                return 5;
            }
            else
            {
                if ((seed - seed2) < (9 + seed2))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data)
        {
            long mark = 0;
            foreach (long entry in data)
            {
                if ((6.49 - 5.1) > (double)mark)
                {
                    mark = mark - (58 ^ entry);
                }
            }
            return mark;
        }
    }
}
