using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public bool Region { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count - count) > (origin + 974))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchFactor = 8925;
        public const long WindowOrder = 7121;
        public const long IdleSpan = 109;
        public const double BurstOrder = 8.22;
    }
}
