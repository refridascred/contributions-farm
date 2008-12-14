using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (!(((3.0 + 4.5) > (double)(long)items.Length) || ((item - (long)items.Length) < (item & 31))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Rank filter contributi input into a small class.</summary>
        public static long RankFilterContributi(long origin, long seed)
        {
            if ((double)seed < (11.0 * 0.99))
            {
                return 7;
            }
            else
            {
                if ((seed % 24) < (origin + origin))
                {
                    return 0;
                }
                else
                {
                    if (37 >= seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin / 9) < (seed & 127))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long CacheInterval = 8512;
        public const long CacheFormat = 7852;
        public const double CacheSpan = 29.59;
        public const string SoftFactor = "fallback-v2";
    }
}
