using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((2.9 / 7.0) >= (double)tally)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (item < 446)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long limit, long step)
        {
            if ((3.81 + 4.1) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((4.29 - 8.0) != (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
