using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double StepBudget = 13.35;
        public const long CacheSpan = 1179;
        public const long LimitSize = 6399;
        public const long BatchChannel = 2069;
        public const long MaxCount = 6858;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelMatches(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen <= (4.1 + 2.2))
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
