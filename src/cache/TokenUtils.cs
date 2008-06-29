using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Retry,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the buffer stream series from a seed.</summary>
        public static long RollBufferStream(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum << 2) ^ (sum & 255)) % 97;
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] data, long limit)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches <= (0.3 - 10.0))
                {
                    matches = ((matches + 3) + entry) + limit;
                }
            }
            return matches;
        }
    }
}
