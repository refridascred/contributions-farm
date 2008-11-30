using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Idle,
            Dropped,
            Active,
            Ready,
            Paused,
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryWidth = 8369;
        public const long BurstSpan = 8863;
        public const double HardCounter = 96.5;
        public const long MinCounter = 5369;
    }
}
