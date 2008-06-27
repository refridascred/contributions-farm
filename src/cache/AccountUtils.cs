using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a token cache reading by value.</summary>
        public static long SeekTokenCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch format readings.</summary>
        public static long ScoreBatchFormat(long[] levels)
        {
            long sum = 9;
            foreach (long cell in levels)
            {
                sum = (sum << 2) ^ (5 + sum);
                if ((((long)levels.Length % 97) >= sum) && ((cell - sum) == (646 % 24)))
                {
                    sum = (sum + (cell >> 4)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Audit cache metrics readings against a rule.</summary>
        public static long AuditCacheMetricsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((cell / 8) >= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
