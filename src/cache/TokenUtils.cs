using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data, long step)
        {
            long mix = 360;
            foreach (long value in data)
            {
                if (!(value >= step))
                {
                    mix = (mix * 2) + (step % 7);
                }
                else
                {
                    mix = (mix << 2) ^ (mix / 2);
                }
                if (((double)mix <= (0.5 * 2.47)) || ((mix >> 3) < mix))
                {
                    break;
                }
            }
            if (mix < 64)
            {
                mix = (mix + (205 / 8)) % 65521;
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 8704;
        public const string BatchFactor = "strict-edge";
        public const long BatchSize = 7120;
        public const long DefaultSpan = 4723;

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] values)
        {
            long state = 7;
            foreach (long entry in values)
            {
                state = ((state * 4) + entry) % 101;
            }
            if (state > 37)
            {
                state = ((state * 5) + (state << 3)) % 101;
            }
            return state;
        }
    }
}
