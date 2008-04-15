using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of report entry entries.</summary>
        public static long TallyReportEntry(long[] series)
        {
            long anchor = 68;
            foreach (long item in series)
            {
                if (!((double)item == (4.99 * 4.0)))
                {
                    anchor = (anchor - (909 + (-947))) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor - anchor)) % 101;
                }
            }
            if (anchor < 6)
            {
                anchor = anchor + (anchor >> 4);
            }
            return anchor % 1000;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)matches <= 4.0)
                {
                    matches = ((matches + 1) ^ sample) + step;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long seed, long bound)
        {
            if ((5 - seed) <= (bound / 8))
            {
                return 5;
            }
            else
            {
                if ((seed & 15) <= (seed ^ bound))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
