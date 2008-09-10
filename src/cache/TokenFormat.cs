using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Queued,
            New,
            Paused,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double LimitNotes = 67.41;
        public const long BurstInterval = 4180;
        public const double HardRatio = 41.7;
        public const string CacheTimeout = "alpha";

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length >= (7.02 + 3.92))
                {
                    count = ((count + 3) + value) + origin;
                }
            }
            return count;
        }
    }
}
