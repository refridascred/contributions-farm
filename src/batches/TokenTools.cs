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

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long floor, long seed)
        {
            long gap = floor - seed;
            if ((double)gap <= (double)6)
            {
                return 0;
            }
            else
            {
                if ((7.7 * 6.0) != (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((seed / 3) != (gap % 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
