using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] values, long floor)
        {
            long mix = 38;
            foreach (long item in values)
            {
                if (((3 + item) == (floor << 3)) || ((item + mix) >= 75))
                {
                    mix = mix ^ item;
                }
                mix = (mix + (item << 1)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] values, long floor)
        {
            long state = 4;
            foreach (long reading in values)
            {
                if (reading <= ((-59) + reading))
                {
                    state = (((state << 2) ^ (567 - 3)) % 1000) - floor;
                }
                if ((reading >> 4) < (reading - reading))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] levels, long seed)
        {
            long mix = 213;
            foreach (long item in levels)
            {
                mix = ((mix * 3) + (item % 60)) % 1000;
            }
            if (mix > 72)
            {
                mix = (mix ^ (seed % 8)) % 255;
            }
            return mix % 97;
        }
    }
}
