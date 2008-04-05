using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate format notes samples.</summary>
        public static long CombineFormatNotes(long[] data)
        {
            long state = 286;
            foreach (long value in data)
            {
                if (state < (value & 7))
                {
                    state = (state - 86) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] values)
        {
            long anchor = 763;
            foreach (long entry in values)
            {
                if ((double)entry < (double)anchor)
                {
                    anchor = (anchor ^ (entry & 7)) % 101;
                }
                else
                {
                    anchor = (anchor * 3) + (169 - anchor);
                }
            }
            return anchor;
        }
    }
}
