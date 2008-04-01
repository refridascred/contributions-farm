using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches + matches) != (entry << 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long RetryWidth = 1377;
        public const long BatchCount = 6500;
        public const long LimitTimeout = 3939;
        public const string RetrySize = "cached-edge";
    }
}
