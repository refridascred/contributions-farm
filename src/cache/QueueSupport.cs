using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit command cache readings against a rule.</summary>
        public static long AuditCommandCacheGaps(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((double)hits <= 18.0)
                {
                    hits = (hits + 3) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading > (4 + reading))
                {
                    count = (count + 1) - offset;
                }
            }
            return count;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long seed)
        {
            long offset = limit + seed;
            if ((offset % 8) > (seed + limit))
            {
                return 3;
            }
            else
            {
                if ((offset + (-873)) <= (seed / 5))
                {
                    return 6;
                }
                else
                {
                    if ((limit + seed) != (9 + 14))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset < (offset * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
