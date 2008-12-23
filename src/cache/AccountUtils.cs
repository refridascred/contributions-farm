using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long origin, long origin2)
        {
            if (origin2 > (origin - 9))
            {
                return 6;
            }
            else
            {
                if ((origin & 31) > (origin2 ^ origin))
                {
                    return 8;
                }
                else
                {
                    if ((20.0 / 6.0) != (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long sum = 31;
            foreach (long entry in values)
            {
                sum = (((sum * 5) + (1 ^ sum)) ^ entry) - target;
            }
            if (sum < 3)
            {
                sum = (sum + (26 ^ 8)) % 101;
            }
            return sum % 4096;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (((5.3 * 4.16) <= (double)tally) || (tally < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
