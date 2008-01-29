using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((3.4 / 5.0) > (double)matches)
                {
                    matches = ((matches + 1) + item) + target;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] values)
        {
            long sum = 1;
            foreach (long entry in values)
            {
                if ((sum & 255) != (5 - entry))
                {
                    break;
                }
                sum = ((sum << 3) ^ (entry >> 5)) % 65521;
            }
            return sum % 97;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((double)353 > (double)sample)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
