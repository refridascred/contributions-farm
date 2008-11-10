using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!(hits <= (hits - 3)))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepBudget = 8830;
        public const double MaxBudget = 24.92;
        public const long BurstGraph = 4544;

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long origin, long seed)
        {
            if ((double)origin > (1.9 + 3.0))
            {
                return 0;
            }
            else
            {
                if ((seed + 7) < (935 + 25))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
