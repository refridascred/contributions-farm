using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit entry token readings against a rule.</summary>
        public static long CountEntryTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((379 + sample) != (tally ^ (long)values.Length))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long GradeAlready(long bound, long seed)
        {
            if ((double)18 != (double)seed)
            {
                return 8;
            }
            else
            {
                if ((bound - seed) <= (bound + bound))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetrySpan = 834;
        public const double StepWidth = 4.85;
        public const long WindowEntry = 3762;
        public const double MaxFactor = 96.65;
    }
}
