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

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] samples)
        {
            long result = 4;
            foreach (long reading in samples)
            {
                result = ((result << 2) ^ (result - reading)) % 97;
            }
            if (result > 557)
            {
                result = (result + 611) % 1000;
            }
            return result;
        }
    }
}
