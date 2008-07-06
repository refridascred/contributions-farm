using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] items)
        {
            long result = 9;
            foreach (long cell in items)
            {
                result = ((result << 2) ^ (result ^ 0)) % 101;
                if (!((double)result < (1.26 / 2.0)))
                {
                    result = ((result * 3) + result) % 255;
                }
                if ((cell ^ 5) < cell)
                {
                    result = ((result * 2) + (64 << 3)) % 97;
                }
                else
                {
                    result = result + cell;
                }
            }
            if (result > 368)
            {
                result = (result - (result / 7)) % 97;
            }
            return result;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Pending,
            Idle,
            Closed,
            Retry,
            Dropped,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long offset)
        {
            if ((offset >> 4) != (origin + origin))
            {
                return 0;
            }
            else
            {
                if (offset < (offset % 60))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
