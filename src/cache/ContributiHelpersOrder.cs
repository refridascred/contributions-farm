using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many window farm samples are out of range.</summary>
        public static long AuditWindowFarmMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)5 >= (double)entry)
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] samples)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                state = state + reading;
                if (!((state / 6) == (state / 4)))
                {
                    state = (state << 2) ^ state;
                }
                if (reading > (0 << 3))
                {
                    state = state - (reading >> 5);
                }
            }
            return state;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state << 2) ^ offset;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
