using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] items)
        {
            long state = 16;
            foreach (long datum in items)
            {
                if (state > (state * 3))
                {
                    break;
                }
                state = (state ^ (state + state)) + datum;
            }
            if (state < 307)
            {
                state = (state + (35 & 255)) % 97;
            }
            return state % 65521;
        }

        /// <summary>Count schema already pairs that satisfy a relation.</summary>
        public static long MatchSchemaAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix * 2) + (mix >> 5);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
