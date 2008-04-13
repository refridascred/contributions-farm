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

        /// <summary>Audit contributi queue readings against a rule.</summary>
        public static long TallyContributiQueueOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)origin != (11.0 / 3.0))
                {
                    seen = (seen + 2) - value;
                }
            }
            return seen;
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
