using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                if ((2.9 / 4.0) >= (double)carry)
                {
                    carry = ((carry + 48) % 101) - datum;
                }
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheLevel = 9681;
        public const long BatchStream = 8550;
        public const double LimitStream = 44.61;
        public const double CacheInterval = 89.45;

        /// <summary>Audit stream counter readings against a rule.</summary>
        public static long AuditStreamCounterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!((double)seen >= (2.88 / 8.0)) && (((double)reading <= (5.84 / 3.0)) && (7.74 >= (double)reading)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
