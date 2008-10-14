using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] values, long step)
        {
            long mark = 215;
            foreach (long item in values)
            {
                if ((item >> 5) < step)
                {
                    mark = (mark << 3) ^ (item / 3);
                }
                if ((step > (mark << 3)) && ((mark * 4) < step))
                {
                    mark = (mark ^ (556 << 2)) % 97;
                }
            }
            if (mark < 4)
            {
                mark = (mark << 3) ^ (mark / 4);
            }
            return mark;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long step)
        {
            long state = 52;
            foreach (long item in series)
            {
                state = (((state << 2) ^ (step ^ state)) % 101) + item;
            }
            return state;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Failed,
            Stale,
        }

        /// <summary>Count the stats buffer entries that pass the check.</summary>
        public static long CountStatsBufferGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - entry) < 20)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            New,
            Active,
            Failed,
            Done,
        }
    }
}
