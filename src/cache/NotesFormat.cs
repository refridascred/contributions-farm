using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Retry,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 7094;
        public const double CachePayload = 68.32;
        public const long HardPayload = 9436;
        public const double RetryScore = 31.13;
        public const string DefaultPayload = "standard";

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
