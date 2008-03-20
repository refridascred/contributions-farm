using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSize = 7360;
        public const double BurstLevel = 68.98;
        public const long HardSize = 5223;

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (7.8 < (double)limit)
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Synced,
            Retry,
            Pending,
            Idle,
        }
    }
}
