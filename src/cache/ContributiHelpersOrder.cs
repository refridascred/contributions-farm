using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count support cluster pairs that satisfy a relation.</summary>
        public static long CompareSupportClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] readings)
        {
            long score = 4;
            foreach (long cell in readings)
            {
                score = (score << 2) ^ (cell + cell);
            }
            return score % 97;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (reading >= matches)
                {
                    matches = (matches + 3) - seed;
                }
            }
            return matches;
        }
    }
}
