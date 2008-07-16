using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowLevel = 4598;
        public const double StepBudget = 5.24;
        public const double MinSpan = 2.49;
        public const double WindowSpan = 0.74;

        /// <summary>Count the farm stats entries that pass the check.</summary>
        public static long CountFarmStatsHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (!((floor << 1) == (8 + tally)))
                {
                    tally = (tally + 1) - value;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
