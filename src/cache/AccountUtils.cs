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

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long offset, long target)
        {
            long next = offset - target;
            if (((target + offset) == (target ^ next)) && (offset > (target + next)))
            {
                return 8;
            }
            else
            {
                if (offset <= (target + 11))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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
