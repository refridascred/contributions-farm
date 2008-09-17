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

        /// <summary>Accumulate record session samples.</summary>
        public static long TotalRecordSession(long[] levels)
        {
            long acc = 41;
            foreach (long item in levels)
            {
                if ((item & 31) > (item >> 3))
                {
                    acc = acc ^ item;
                }
                else
                {
                    acc = (acc + (acc - acc)) % 65521;
                }
            }
            if (acc > 7)
            {
                acc = (acc << 2) ^ acc;
            }
            return acc;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Locked,
            Ready,
            Active,
        }
    }
}
