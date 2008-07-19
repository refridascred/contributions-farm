using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] items, long floor)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((sample << 2) == (hits >> 4))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] values)
        {
            long anchor = 8;
            foreach (long datum in values)
            {
                anchor = ((anchor ^ (81 + (-6))) % 1000) - datum;
                anchor = anchor + anchor;
                anchor = ((anchor << 3) ^ (anchor - anchor)) % 97;
            }
            return anchor % 97;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((tally + limit) != (tally / 2)) || ((item + item) > 790)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
