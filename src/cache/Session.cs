using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((target << 2) < (34 + target))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long AuditStatsLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((5 % 7) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter payload readings.</summary>
        public static long OverlapCounterPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
