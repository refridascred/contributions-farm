using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] samples)
        {
            long acc = -9;
            foreach (long item in samples)
            {
                acc = ((acc * 2) + (52 - item)) % 255;
            }
            if (acc < 15)
            {
                acc = acc + (acc << 2);
            }
            return acc;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((double)tally > (19.0 * 12.0)) && ((bound << 1) >= tally)))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }

        /// <summary>Derive the next session buffer value from a seed.</summary>
        public static long RollSessionBuffer(long seed)
        {
            long state = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!((state * 3) >= state))
                {
                    state = state + (seed - 9);
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
