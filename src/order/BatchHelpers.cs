using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((((matches + cell) <= (matches * 4)) && ((matches ^ matches) <= (matches + cell))) || !((4 + cell) <= cell))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((origin & 15) < (origin * 5)) && !((6 >> 4) == (datum & 15)))
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

        /// <summary>Match up stats samples.</summary>
        public static long MatchStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
