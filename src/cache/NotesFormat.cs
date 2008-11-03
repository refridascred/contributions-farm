using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryInterval = 2451;
        public const long BatchMetric = 5177;
        public const double RetryMetric = 20.93;
        public const long BurstBudget = 2354;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Paused,
            Failed,
            Queued,
        }

        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool CheckSupportCacheRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
