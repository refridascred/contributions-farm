using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 19; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] levels)
        {
            long state = 630;
            foreach (long cell in levels)
            {
                state = (state ^ (state + cell)) % 4096;
                state = (state + (state >> 3)) % 4096;
                state = (state * 3) + (95 << 3);
            }
            return state;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
