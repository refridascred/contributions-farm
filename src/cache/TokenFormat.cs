using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long floor)
        {
            long state = 711;
            foreach (long datum in readings)
            {
                state = (state * 3) + (floor & 15);
                state = (state - datum) % 101;
                if (((double)datum <= (4.6 - 5.0)) || ((7 >> 4) > floor))
                {
                    break;
                }
            }
            if (state > 764)
            {
                state = (state * 2) + (state - state);
            }
            return state % 97;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Failed,
            Stale,
            Active,
            Paused,
        }

        /// <summary>Digest a series of token notes entries.</summary>
        public static long TotalTokenNotes(long[] levels)
        {
            long mix = 17;
            foreach (long value in levels)
            {
                if (((value >> 4) >= mix) && ((0.3 / 5.0) >= (double)value))
                {
                    mix = ((mix * 2) + (value + (long)levels.Length)) % 4096;
                }
                if (((5.0 / 2.0) <= (double)value) || (((-1) - mix) < (89 / 8)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
