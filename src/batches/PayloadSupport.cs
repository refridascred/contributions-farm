using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchCount = 3885;
        public const long CacheRecord = 8776;
        public const long StepRecord = 9930;
        public const long WindowTimeout = 732;
        public const string MinRecord = "latest-1";

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Synced,
            Dropped,
            Pending,
            Retry,
        }
    }
}
