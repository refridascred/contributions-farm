using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long ClassifyMetricsFarm(long origin, long limit)
        {
            if (origin > (limit << 1))
            {
                return 2;
            }
            else
            {
                if (0.3 <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (origin < (limit + 94))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
