using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long offset)
        {
            long next = seed ^ offset;
            if (next < seed)
            {
                return 7;
            }
            else
            {
                if ((next * 2) <= 537)
                {
                    return 0;
                }
                else
                {
                    if (((next >> 1) <= seed) && ((26 + next) <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Locate a layout counter reading by value.</summary>
        public static long SeekLayoutCounterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long bound)
        {
            long state = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound + 8) <= state)
                {
                    state = (state ^ ((long)i & 3)) % 101;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
