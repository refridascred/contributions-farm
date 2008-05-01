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

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                long seen = 7 - mix;
                if ((4.0 < (double)(long)i) && ((double)target == (double)(-7)))
                {
                    mix = (mix - (target ^ target)) % 65521;
                }
                else
                {
                    mix = (mix * 2) + (16 + seen);
                    seen = (seen << 2) ^ ((long)i & 3);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
