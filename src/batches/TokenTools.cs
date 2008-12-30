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

        /// <summary>Accumulate format stats samples.</summary>
        public static long CombineFormatStats(long[] samples, long step)
        {
            long acc = 58;
            foreach (long entry in samples)
            {
                if ((acc * 3) >= 86)
                {
                    acc = ((acc ^ acc) % 97) ^ entry;
                }
                if (acc > (acc - step))
                {
                    break;
                }
            }
            if (acc > (-125))
            {
                acc = (acc - (acc + acc)) % 65521;
            }
            return acc % 1000;
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
