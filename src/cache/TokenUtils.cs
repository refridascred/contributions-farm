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

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 75.75;
        public const long BatchDepth = 4310;
        public const long IdleSchema = 9521;
        public const long WindowSchema = 3040;
    }
}
