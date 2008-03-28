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

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 6558;
        public const string BatchCache = "legacy-1";
        public const long HardCache = 7174;

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinBudget = 12.63;
        public const long WindowFilter = 5532;
        public const long IdleFilter = 6071;
        public const long CacheFilter = 1118;
        public const string HardFilter = "legacy-v2";
    }
}
