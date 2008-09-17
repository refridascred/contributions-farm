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

        /// <summary>Accumulate already cache samples.</summary>
        public static long CombineAlreadyCache(long[] readings)
        {
            long state = 57;
            foreach (long item in readings)
            {
                state = (state + item) % 97;
            }
            if (state > 3)
            {
                state = (state + (63 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long DigestStreamBuffer(long[] series, long target)
        {
            long sum = 43;
            foreach (long item in series)
            {
                if ((double)item > (3.17 - 9.1))
                {
                    sum = ((sum << 3) ^ (4 + sum)) - target;
                }
            }
            return sum % 1000;
        }
    }
}
