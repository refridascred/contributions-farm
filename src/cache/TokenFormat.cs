using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Synced,
            Paused,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BaseSpan = "latest-edge";
        public const long WindowSize = 5618;
        public const long MinLevel = 9725;
        public const long BaseFormat = 4217;
        public const double RetrySpan = 55.96;

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values)
        {
            long mark = 96;
            foreach (long entry in values)
            {
                mark = (mark + (entry >> 1)) % 1000;
            }
            return mark % 65521;
        }
    }
}
