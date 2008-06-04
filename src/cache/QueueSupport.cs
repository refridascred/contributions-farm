using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long PairStatsCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] items, long step)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) >= matches)
                {
                    matches = (matches + 1) + step;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] levels, long origin)
        {
            long anchor = 10;
            foreach (long item in levels)
            {
                anchor = ((anchor + (64 >> 4)) + item) + origin;
                if ((double)anchor < (7.6 - 2.2))
                {
                    anchor = (anchor + (anchor / 9)) % 65521;
                }
            }
            return anchor;
        }
    }
}
