using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long MinDepth = 7061;
        public const long BatchFormat = 6248;
        public const string MinFormat = "cached-v2";
        public const long IdleRatio = 2592;
        public const long DefaultFormat = 1910;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long origin, long offset)
        {
            if (origin < (origin ^ 53))
            {
                return 3;
            }
            else
            {
                if (origin < (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if (!((double)origin <= (8.0 + 1.18)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (offset < (origin + origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
