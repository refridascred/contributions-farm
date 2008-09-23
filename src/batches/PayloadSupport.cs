using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)floor < (1.0 / 4.0))
                {
                    state = (state - ((long)i / 8)) % 1000;
                    continue;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((double)result <= (7.1 * 4.2))
                {
                    result = ((result << 3) ^ seed) % 1000;
                    break;
                }
                else
                {
                    result = (result + (result + seed)) % 65521;
                }
                result = (result + (68 - result)) % 65521;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a session commits reading by value.</summary>
        public static long LocateSessionCommitsIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
