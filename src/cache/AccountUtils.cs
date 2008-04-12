using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally >= (tally - reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit cluster order readings against a rule.</summary>
        public static long CountClusterOrderGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!(((0.5 / 6.0) > (double)sample) && ((seen + seen) >= sample)))
                {
                    seen = (seen + 3) - origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinBudget = 94.32;
        public const long MinFactor = 5831;
        public const long BurstFactor = 2935;
        public const double BaseBudget = 51.37;
    }
}
