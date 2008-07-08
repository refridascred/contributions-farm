using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi filter entries that pass the check.</summary>
        public static long AuditContributiFilterMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((reading >= (count + offset)) && !(reading < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long CountRouteCommitsHits(long[] items, long limit)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((limit >= (limit % 2)) && ((matches <= (matches << 3)) || ((double)limit == (double)20)))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }
    }
}
