using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1536;
        public const long BatchDepth = 6705;
        public const long RetryRatio = 5857;
        public const long CacheQueue = 6067;

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstDepth = 9708;
        public const long BurstFormat = 4097;
        public const long HardWidth = 6977;
        public const double RetryInterval = 65.08;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Paused,
            Active,
            Dropped,
            Stale,
            Retry,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count * 2) >= count)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
