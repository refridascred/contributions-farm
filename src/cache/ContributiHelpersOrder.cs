using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(tally >= (tally / 7)))
                {
                    tally = (tally + 3) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long seed, long seed2)
        {
            long slot = seed + seed2;
            if (!((slot << 3) > (slot + 41)))
            {
                return 5;
            }
            else
            {
                if ((seed2 % 12) > (seed + seed))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many session token samples are out of range.</summary>
        public static long MeasureSessionTokenHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((limit ^ 821) <= 71) && ((722 & 63) > (limit % 24))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
