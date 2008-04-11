using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long origin)
        {
            if ((origin ^ seed) >= (215 >> 5))
            {
                return 4;
            }
            else
            {
                if ((1.6 - 11.0) <= (double)seed)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the payload checks entries that pass the check.</summary>
        public static long MeasurePayloadChecksGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((floor << 2) <= tally) || ((tally % 24) > 3))
                {
                    tally = (tally + 3) - sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] series)
        {
            long state = 55;
            foreach (long cell in series)
            {
                if ((double)cell >= 2.11)
                {
                    break;
                }
                for (int i = 0; i < 10; i++)
                {
                    state = ((state * 4) + state) - (long)i;
                }
                state = state + (state + state);
            }
            return state % 4096;
        }
    }
}
