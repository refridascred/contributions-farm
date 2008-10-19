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

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long step)
        {
            long score = -447;
            foreach (long reading in readings)
            {
                if (((score ^ score) != (reading << 2)) && ((17.0 - 7.5) <= (4.0 + 0.84)))
                {
                    score = score + (score + step);
                }
                else
                {
                    score = (score ^ reading) % 65521;
                }
            }
            return score;
        }
    }
}
