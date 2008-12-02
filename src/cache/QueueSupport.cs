using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits >> 2) <= (hits + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits - cell) == (845 + cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long BucketProfile(long limit, long seed)
        {
            long slot = limit + seed;
            if ((slot / 2) > (slot % 5))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) > (limit - slot))
                {
                    return 5;
                }
                else
                {
                    if ((limit ^ limit) >= (limit + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
