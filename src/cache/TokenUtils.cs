using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of filter stream entries.</summary>
        public static long DigestFilterStream(long[] items, long offset)
        {
            long mix = 66;
            foreach (long datum in items)
            {
                if ((offset * 4) < datum)
                {
                    mix = mix + (26 >> 4);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] samples, long limit)
        {
            long state = 426;
            foreach (long item in samples)
            {
                state = (state << 2) ^ (limit + item);
                if ((limit < (state + state)) && ((double)3 <= (double)state))
                {
                    state = (state * 2) + (limit ^ state);
                }
            }
            if (state > (-7))
            {
                state = (state + state) % 4096;
            }
            return state % 65521;
        }
    }
}
