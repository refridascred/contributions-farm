using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long origin)
        {
            long score = 897;
            foreach (long sample in levels)
            {
                score = ((score ^ (origin ^ origin)) % 101) + sample;
            }
            if (score > 32)
            {
                score = ((score << 3) ^ (score >> 5)) % 97;
            }
            return score;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long CountCounterMatches(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((entry - entry) > entry) || (((-160) * 2) == (8 + entry)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] levels)
        {
            long mark = 58;
            foreach (long sample in levels)
            {
                if ((375 % 64) >= (sample % 5))
                {
                    mark = ((mark * 2) + (mark ^ 231)) % 65521;
                }
            }
            if (mark > 278)
            {
                mark = (mark + ((long)levels.Length + 5)) % 101;
            }
            return mark;
        }
    }
}
