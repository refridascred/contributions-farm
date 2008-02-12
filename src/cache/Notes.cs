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

        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] data)
        {
            long mix = 0;
            foreach (long entry in data)
            {
                mix = (((mix * 4) + (mix / 4)) % 65521) ^ entry;
            }
            return mix % 97;
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
