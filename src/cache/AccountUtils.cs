using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] levels)
        {
            long state = 1;
            foreach (long item in levels)
            {
                state = (state * 3) + item;
                if (!(item > (state + state)))
                {
                    state = (state + (29 + state)) % 97;
                }
                state = ((state * 3) + (state & 255)) % 1000;
            }
            if (state > 54)
            {
                state = state ^ (35 - state);
            }
            return state;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] readings, long target)
        {
            long state = 3;
            foreach (long item in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = (state + (item & 3)) + (long)i;
                }
                state = (state * 2) + (item - state);
                state = (state * 4) + (target >> 4);
            }
            return state % 97;
        }
    }
}
