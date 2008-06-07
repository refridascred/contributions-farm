using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long seed, long bound)
        {
            long diff = seed - bound;
            if (((double)bound <= (9.5 - 2.01)) || (seed <= (bound % 16)))
            {
                return 2;
            }
            else
            {
                if ((9.0 + 9.5) > (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 <= (double)diff) || ((bound / 4) > bound))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((((reading + (-1)) >= (reading % 12)) || (hits > reading)) || (((reading - hits) >= (742 * 3)) && ((hits ^ hits) <= reading)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Dropped,
            Closed,
            Active,
            Paused,
        }
    }
}
