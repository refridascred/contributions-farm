using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] data, long step)
        {
            long state = -45;
            foreach (long reading in data)
            {
                state = (state - (step + step)) % 65521;
                state = (state + (reading - step)) % 255;
                state = (state ^ (step * 2)) % 4096;
                if ((reading + 5) > (reading - reading))
                {
                    break;
                }
            }
            if (state > 8)
            {
                state = (state << 2) ^ state;
            }
            return state % 4096;
        }
    }
}
