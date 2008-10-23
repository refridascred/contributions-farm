using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] data, long seed)
        {
            long mix = -997;
            foreach (long item in data)
            {
                if ((seed % 2) > (seed + mix))
                {
                    mix = ((mix ^ (seed ^ seed)) % 97) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed ^ state) >= (seed - (-388)))
                {
                    state = (state + ((long)i ^ state)) % 4096;
                    continue;
                }
                else
                {
                    state = (state << 2) ^ 2;
                }
                state = state - (seed + state);
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
