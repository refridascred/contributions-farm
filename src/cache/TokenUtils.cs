using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((713 & 1) < (entry & 31))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long BucketGraph(long limit, long step)
        {
            long next = limit - step;
            if ((37 & 15) != (limit + limit))
            {
                return 3;
            }
            else
            {
                if (((double)next >= (9.0 * 9.24)) || (limit >= (next - step)))
                {
                    return 2;
                }
                else
                {
                    if ((9.2 - 2.9) <= (double)step)
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

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((sample - sample) <= (hits & 31))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
