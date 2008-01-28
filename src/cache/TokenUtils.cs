using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 31.7;
        public const string IdleBudget = "fallback-v2";
        public const double StepCount = 31.57;
        public const long CacheRatio = 397;

        /// <summary>Rank checks entry input into a small class.</summary>
        public static long BucketChecksEntry(long limit, long origin)
        {
            long diff = limit - origin;
            if ((origin / 3) > (limit & 3))
            {
                return 0;
            }
            else
            {
                if (((711 + origin) <= diff) && ((origin >> 1) > diff))
                {
                    return 1;
                }
                else
                {
                    if ((diff + limit) != (diff + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long SeekNotesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
