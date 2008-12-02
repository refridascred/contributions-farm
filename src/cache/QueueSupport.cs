using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryLimits(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
