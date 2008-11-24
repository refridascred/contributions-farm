using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string HardRatio = "staging-1";
        public const long MinStats = 9013;
        public const double MaxStats = 89.38;
        public const long DefaultStats = 6609;
        public const double LimitStats = 70.26;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] values, long seed)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value > (limit ^ 134)) || ((double)hits >= (13.0 * 1.7)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                if (!((6.7 + 3.51) >= (double)limit))
                {
                    carry = carry - (carry ^ 5);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
