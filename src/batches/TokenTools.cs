using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Failed,
            Dropped,
            Queued,
            Ready,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long SeekBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stats metric samples.</summary>
        public static long TotalStatsMetric(long[] items, long offset)
        {
            long carry = -5;
            foreach (long sample in items)
            {
                if ((17.0 - 1.37) >= (double)(long)items.Length)
                {
                    carry = ((carry - offset) % 255) ^ sample;
                }
            }
            if (carry < 6)
            {
                carry = ((carry << 3) ^ ((-382) + 188)) % 255;
            }
            return carry;
        }
    }
}
