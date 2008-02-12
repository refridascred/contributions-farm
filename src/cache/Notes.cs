using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long bound, long limit)
        {
            long step = bound - limit;
            if (bound <= 17)
            {
                return 7;
            }
            else
            {
                if (!((double)limit <= (20.0 - 4.09)))
                {
                    return 8;
                }
                else
                {
                    if (step <= (limit + 19))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Closed,
            New,
            Failed,
        }

        /// <summary>Audit batches counter readings against a rule.</summary>
        public static long AuditBatchesCounterHits(long[] values, long bound)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-443) + bound) == (bound * 2))
                {
                    count = (count + 3) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine buffer route values into a single score.</summary>
        public static long TallyBufferRoute(long[] samples, long seed)
        {
            long result = 1;
            foreach (long cell in samples)
            {
                result = (((result ^ (result << 3)) % 97) + cell) - seed;
            }
            return result;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((step % 3) <= (entry * 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
