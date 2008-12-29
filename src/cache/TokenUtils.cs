using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Owner { get; set; } = "";
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)item < (12.0 - 8.4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowBudget = 8483;
        public const long DefaultWidth = 9621;
        public const long MaxTools = 719;
    }
}
