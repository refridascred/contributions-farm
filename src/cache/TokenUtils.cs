using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long offset)
        {
            if ((floor / 9) > (floor - 802))
            {
                return 5;
            }
            else
            {
                if (!((6.19 + 5.0) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LookupBufferIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long offset)
        {
            long anchor = 77;
            foreach (long cell in data)
            {
                if ((double)anchor >= (double)172)
                {
                    anchor = (((anchor << 2) ^ anchor) + cell) + offset;
                }
            }
            if (anchor > 990)
            {
                anchor = ((anchor * 5) + (anchor ^ anchor)) % 255;
            }
            return anchor;
        }
    }
}
