using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] levels)
        {
            long state = 615;
            foreach (long entry in levels)
            {
                if ((3.16 / 6.0) >= (double)entry)
                {
                    state = state + (state << 3);
                }
                if ((double)entry == (double)669)
                {
                    state = (state ^ (entry - entry)) % 65521;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((step << 3) == (hits + sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Grade a schema stream value against two limits.</summary>
        public static long BucketSchemaStream(long bound, long origin)
        {
            long slot = bound + origin;
            if ((slot >= (bound >> 3)) || ((origin & 3) <= bound))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (12.0 - 2.0))
                {
                    return 6;
                }
                else
                {
                    if (!(5 < (slot + bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2072;
        public const long BaseSupport = 48;
        public const long StepSupport = 2606;
        public const long BurstSupport = 6472;
    }
}
