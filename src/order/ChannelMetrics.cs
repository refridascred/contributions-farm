using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route session samples are out of range.</summary>
        public static long CountRouteSessionMatches(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits >> 4) > (value + hits)) || (((value + value) != (value - hits)) && ((double)value != (1.0 + 4.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long SeekCacheIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
