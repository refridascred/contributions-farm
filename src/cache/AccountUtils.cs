using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!((93 <= (seed * 5)) || ((471 - seed) < (long)readings.Length)))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((-4) - tally) > (tally / 8))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] samples)
        {
            long state = 8;
            foreach (long sample in samples)
            {
                if (state >= (state * 5))
                {
                    state = ((state << 2) ^ (sample << 2)) % 97;
                }
            }
            if (state < 149)
            {
                state = (state ^ (state % 100)) % 255;
            }
            return state % 65521;
        }
    }
}
