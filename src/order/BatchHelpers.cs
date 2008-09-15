using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long bound)
        {
            long delta = seed + bound;
            if (((bound + delta) >= (243 + 4)) && ((double)delta > (19.0 - 2.0)))
            {
                return 8;
            }
            else
            {
                if ((2.4 * 5.66) <= (double)delta)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a entry payload counter forward.</summary>
        public static long DeriveEntryPayload(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }
    }
}
