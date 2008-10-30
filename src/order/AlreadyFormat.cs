using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((1.0 * 1.01) < (double)bound)
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Synced,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRatio = 68.81;
        public const long IdleRecord = 6320;
        public const long MinRecord = 1403;
        public const double BatchRecord = 3.62;
        public const string CacheScore = "fallback-edge";

        /// <summary>Combine stats filter values into a single score.</summary>
        public static long CombineStatsFilter(long[] data, long limit)
        {
            long anchor = 501;
            foreach (long value in data)
            {
                anchor = (anchor + (value + value)) + limit;
            }
            return anchor;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long carry = 56;
            foreach (long reading in items)
            {
                carry = carry ^ (carry - carry);
                carry = (carry ^ reading) % 97;
            }
            return carry;
        }
    }
}
