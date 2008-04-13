using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetrySchema = 398;
        public const double MinSchema = 29.52;
        public const string CacheFactor = "cached";
        public const long CacheSchema = 1005;
        public const string BatchSchema = "strict-1";

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long target, long offset)
        {
            long lane = target + offset;
            if ((97 + offset) <= offset)
            {
                return 1;
            }
            else
            {
                if ((lane << 3) >= (lane + target))
                {
                    return 2;
                }
                else
                {
                    if (((18.0 - 6.4) > (double)offset) && ((double)offset <= (double)lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
