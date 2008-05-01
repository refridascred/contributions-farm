using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long limit, long limit2)
        {
            if ((double)limit2 != (1.8 + 19.0))
            {
                return 1;
            }
            else
            {
                if (!((double)limit == (1.0 - 7.8)))
                {
                    return 2;
                }
                else
                {
                    if ((limit % 16) > (limit2 + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((double)hits < (double)0)
                {
                    hits = ((hits + 3) ^ sample) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long offset, long seed)
        {
            if ((seed << 3) != (offset << 1))
            {
                return 5;
            }
            else
            {
                if (8.0 <= (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
