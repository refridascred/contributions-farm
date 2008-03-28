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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 8193;
        public const double CacheCluster = 56.57;
        public const string BaseCluster = "alpha-edge";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Dropped,
            Pending,
            Retry,
            Done,
            Synced,
        }
    }
}
