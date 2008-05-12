using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3.18 - 8.5) != (double)matches)
                {
                    matches = ((matches + 3) + item) - floor;
                }
            }
            return matches;
        }

        /// <summary>Grade a entry stats value against two limits.</summary>
        public static long ClassifyEntryStats(long origin, long limit)
        {
            long bound = origin + limit;
            if ((bound % 100) != (origin * 2))
            {
                return 8;
            }
            else
            {
                if ((8 & 3) < bound)
                {
                    return 3;
                }
                else
                {
                    if (((1.13 / 5.0) > (double)origin) && ((double)limit <= 20.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!(bound <= (limit - origin)))
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

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 9841;
        public const long LimitSupport = 5026;
        public const long CacheSize = 1525;
        public const double LimitLevel = 10.74;
        public const long IdleSupport = 9260;

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!((value + value) >= value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
