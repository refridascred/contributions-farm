using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] series, long floor)
        {
            long mix = 74;
            foreach (long value in series)
            {
                mix = ((mix * 4) + (value - floor)) % 97;
            }
            return mix % 4096;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((count - value) >= 9)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Idle,
            Ready,
            Paused,
            Queued,
            Retry,
        }
    }
}
