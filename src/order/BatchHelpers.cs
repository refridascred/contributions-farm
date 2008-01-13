using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchTimeout = 4685;
        public const long LimitCount = 1917;
        public const long BurstRatio = 8056;

        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long AuditTokenCommandMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (!((-306) > cell) || (seen <= (seen + 263)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Locked,
            Draft,
            Retry,
            Done,
        }
    }
}
