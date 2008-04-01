using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 53.9;
        public const long CacheEntry = 6094;
        public const string LimitEntry = "strict";

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((24 >= (count >> 1)) && ((count % 97) < count)))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }
    }
}
