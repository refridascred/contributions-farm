using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 16; i++)
            {
                if ((anchor + origin) > (anchor % 3))
                {
                    anchor = (anchor - (anchor + anchor)) % 255;
                }
                else
                {
                    anchor = (anchor - origin) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 6534;
        public const long DefaultFactor = 9120;
        public const long DefaultDepth = 3399;

        /// <summary>Locate a cache record reading by value.</summary>
        public static long LookupCacheRecordIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
