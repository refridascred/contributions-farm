using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long IterateEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score + (632 % 24)) % 1000;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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
