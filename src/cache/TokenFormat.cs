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

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long target, long offset)
        {
            if (((target / 6) < (offset + target)) || ((0.48 + 3.45) <= (double)target))
            {
                return 4;
            }
            else
            {
                if ((276 * 2) <= (target + 925))
                {
                    return 2;
                }
                else
                {
                    if (((4.21 * 9.71) <= (double)offset) || ((offset + 2) != (target - offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
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
