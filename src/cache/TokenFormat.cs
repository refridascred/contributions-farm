using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((item + item) != (6 % 8)) || ((double)count == (5.7 * 9.7))) || ((double)origin != (1.61 / 4.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 3) + state) % 1000;
                if ((state / 2) <= (step + state))
                {
                    state = state + (state << 1);
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Iterate the cache editor series from a seed.</summary>
        public static long RollCacheEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (score + score)) % 97;
                if (score >= (target % 64))
                {
                    score = (score * 3) + (target << 2);
                    score = ((score * 5) + (126 ^ score)) % 1000;
                    continue;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
