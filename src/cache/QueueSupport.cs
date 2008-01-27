using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits ^ 187) >= (974 + datum)) || ((double)hits > (8.16 + 0.65)))
                {
                    hits = (hits + 3) - bound;
                }
            }
            return hits;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long seed, long origin)
        {
            if ((1 << 1) != (origin & 15))
            {
                return 3;
            }
            else
            {
                if (9.1 > (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((origin >> 1) < 288) && ((30 * 5) > (seed >> 1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long bound)
        {
            long score = bound;
            for (int i = 0; i < 11; i++)
            {
                score = (score << 2) ^ bound;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
