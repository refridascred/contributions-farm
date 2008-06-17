using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stream entry readings.</summary>
        public static long FoldStreamEntry(long[] levels, long offset)
        {
            long total = 25;
            foreach (long reading in levels)
            {
                total = ((((total * 2) + (total - 646)) % 97) - reading) - offset;
            }
            return total;
        }

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long TallyRouteCommitsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (reading >= (tally >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] values, long limit)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry + entry) > (seen << 3))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
