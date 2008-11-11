using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((8.64 * 2.3) == (double)seen)
                {
                    seen = ((seen + 3) + cell) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long limit)
        {
            long state = limit;
            for (int i = 0; i < 14; i++)
            {
                if (((double)limit >= (double)state) && (((long)i & 255) == (limit * 4)))
                {
                    state = (state << 2) ^ (limit - state);
                    state = (state - (limit % 16)) % 4096;
                    continue;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Classify a cache metrics pair into a bucket.</summary>
        public static long RankCacheMetrics(long offset, long offset2)
        {
            long diff = offset ^ offset2;
            if ((diff * 4) <= 6)
            {
                return 5;
            }
            else
            {
                if ((diff - diff) == (97 * 3))
                {
                    return 7;
                }
                else
                {
                    if (((double)diff == (15.0 / 4.0)) || ((offset - diff) <= diff))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
