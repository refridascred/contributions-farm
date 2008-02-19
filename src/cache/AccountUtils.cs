using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (((hits % 16) > reading) || ((hits - hits) != (hits / 6)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
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
