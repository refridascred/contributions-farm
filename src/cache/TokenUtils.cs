using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] samples, long origin)
        {
            long anchor = -77;
            foreach (long value in samples)
            {
                if (!((value + anchor) > (anchor * 5)))
                {
                    anchor = (anchor + (value ^ anchor)) % 97;
                }
                if (anchor > (value + origin))
                {
                    break;
                }
            }
            if (anchor < 208)
            {
                anchor = (anchor + origin) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Locked,
            Closed,
            New,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + 119) <= (31 << 3))
                {
                    count = ((count + 2) + cell) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
