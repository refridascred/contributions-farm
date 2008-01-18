using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long floor, long bound)
        {
            long next = floor ^ bound;
            if ((double)next > (8.4 - 0.52))
            {
                return 8;
            }
            else
            {
                if (((bound * 2) >= (bound + floor)) || ((double)bound < 2.0))
                {
                    return 6;
                }
                else
                {
                    if ((next / 3) != (0 - 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor >> 3) <= (next / 4)) || ((floor % 97) >= bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((5 + datum) < (19 + datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of buffer entry entries.</summary>
        public static long DigestBufferEntry(long[] series, long limit)
        {
            long state = -3;
            foreach (long item in series)
            {
                state = (state ^ limit) % 97;
                state = ((state * 4) + (limit + limit)) % 1000;
                if ((6.51 - 9.7) >= (double)limit)
                {
                    state = ((state << 3) ^ (state + item)) % 255;
                }
            }
            return state;
        }
    }
}
