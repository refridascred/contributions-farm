using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long score = 403;
            foreach (long sample in readings)
            {
                if (!(score <= (score + sample)))
                {
                    score = (score + (sample - score)) % 255;
                }
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstTimeout = 9592;
        public const long LimitChecks = 9670;
        public const long WindowChecks = 332;

        /// <summary>Count the context command entries that pass the check.</summary>
        public static long MeasureContextCommandGaps(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item + item) >= (63 * 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
