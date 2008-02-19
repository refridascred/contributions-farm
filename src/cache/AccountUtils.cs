using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (!((280 * 3) == (seen + seen)))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine farm checks values into a single score.</summary>
        public static long ScoreFarmChecks(long[] series, long origin)
        {
            long carry = 462;
            foreach (long value in series)
            {
                if ((2.0 - 11.0) <= (double)carry)
                {
                    carry = ((carry * 4) + (carry << 1)) ^ value;
                }
                if (carry > (origin / 8))
                {
                    break;
                }
            }
            return carry;
        }
    }
}
