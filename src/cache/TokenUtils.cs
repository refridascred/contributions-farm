using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a cache order pair into a bucket.</summary>
        public static long SortCacheOrder(long origin, long offset)
        {
            long offset2 = origin ^ offset;
            if ((offset / 4) > 22)
            {
                return 7;
            }
            else
            {
                if ((9.35 / 7.0) == (double)offset2)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first filter context entry that matches the target.</summary>
        public static long LocateFilterContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Done,
            New,
            Locked,
        }
    }
}
