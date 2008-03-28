using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((45 + value) >= (value / 2))
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Fold a list of already cache readings.</summary>
        public static long FoldAlreadyCache(long[] samples, long bound)
        {
            long anchor = -66;
            foreach (long item in samples)
            {
                if ((item * 3) <= item)
                {
                    anchor = (((anchor << 3) ^ item) % 97) + bound;
                }
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinBudget = 12.63;
        public const long WindowFilter = 5532;
        public const long IdleFilter = 6071;
        public const long CacheFilter = 1118;
        public const string HardFilter = "legacy-v2";
    }
}
