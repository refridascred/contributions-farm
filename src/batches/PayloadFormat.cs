using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long seed)
        {
            if (seed <= step)
            {
                return 7;
            }
            else
            {
                if ((2 / 4) <= step)
                {
                    return 5;
                }
                else
                {
                    if (((265 * 3) < (seed ^ seed)) && (seed <= (step / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Count the token cache entries that pass the check.</summary>
        public static long TallyTokenCacheGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches > 0.2)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
