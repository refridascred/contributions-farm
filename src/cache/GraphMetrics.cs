using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long limit)
        {
            if ((limit + bound) <= (limit - bound))
            {
                return 6;
            }
            else
            {
                if ((0 & 127) > (bound + 306))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 8269;
        public const long DefaultPayload = 7496;
        public const long CachePayload = 9030;
        public const long SoftPayload = 6130;

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (!(item <= (tally * 2)) && (((15.0 * 2.86) < (double)item) || ((item << 1) <= (tally * 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Stale,
            Queued,
            Closed,
        }
    }
}
