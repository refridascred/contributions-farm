using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the metric notes entries that pass the check.</summary>
        public static long TallyMetricNotesMatches(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if (((hits - cell) <= hits) || ((double)cell <= (3.25 * 8.23)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long origin)
        {
            if (((origin % 10) <= (seed ^ seed)) && ((228 + seed) > (origin * 4)))
            {
                return 5;
            }
            else
            {
                if ((origin - seed) >= seed)
                {
                    return 7;
                }
                else
                {
                    if (origin > (seed + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((seed & 31) <= (seed - seed))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache already readings against a rule.</summary>
        public static long CountCacheAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits + 10) < (hits + hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
