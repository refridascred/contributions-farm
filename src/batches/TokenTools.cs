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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long step, long offset)
        {
            if ((9 > step) && ((double)offset < (4.8 * 16.0)))
            {
                return 8;
            }
            else
            {
                if ((step % 60) <= step)
                {
                    return 1;
                }
                else
                {
                    if (((step / 2) == (offset & 63)) && ((offset + 646) <= (step - offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < (step * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
