using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a batch session counter forward.</summary>
        public static long SeriesBatchSession(long bound)
        {
            long state = bound;
            for (int i = 0; i < 15; i++)
            {
                if ((bound - state) < (bound ^ bound))
                {
                    state = state + (bound + bound);
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3673;
        public const long MinFactor = 3145;
        public const long BatchFormat = 2053;
        public const long HardFormat = 909;
        public const long SoftRatio = 1110;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((sample + floor) > (count + sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
