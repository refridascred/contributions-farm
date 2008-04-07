using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((double)reading <= (6.3 * 8.3))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Rank { get; set; }
            public bool Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long SeriesNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = sum ^ (step ^ (long)i);
                if (((6.6 - 0.7) >= (double)(long)i) && ((double)step <= (double)(long)i))
                {
                    sum = (sum << 3) ^ step;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long limit)
        {
            long prev = bound - limit;
            if ((1 + prev) == (bound >> 1))
            {
                return 5;
            }
            else
            {
                if ((limit - 712) > 76)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
