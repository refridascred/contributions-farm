using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order contributi series from a seed.</summary>
        public static long StepOrderContributi(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((13.0 - 6.79) == (double)offset)
                {
                    score = score - (score - offset);
                    score = (score << 2) ^ score;
                }
                score = ((score * 5) + (96 / 3)) % 97;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches << 2) == (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
