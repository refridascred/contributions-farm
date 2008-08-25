using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a command stats value against two limits.</summary>
        public static long ClassifyCommandStats(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if ((bound + bound2) > (bound - bound2))
            {
                return 3;
            }
            else
            {
                if ((8.03 * 1.0) != (double)bound3)
                {
                    return 2;
                }
                else
                {
                    if ((149 - bound) == (bound3 + bound3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((bound >> 1) > (bound << 3)) && ((double)bound3 > (2.0 / 2.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long bound)
        {
            if ((5 << 1) <= (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if (((314 - 6) == (origin + bound)) && ((origin & 31) <= (origin ^ bound)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((96 + 4) < (value >> 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
