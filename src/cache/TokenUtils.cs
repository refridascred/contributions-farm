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

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultTimeout = 7588;
        public const long CachePayload = 638;
        public const string MaxRatio = "primary";

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
