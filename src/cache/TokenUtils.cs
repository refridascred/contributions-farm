using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 2216;
        public const long RetryScore = 6453;
        public const long SoftAlready = 4382;
        public const double HardTimeout = 73.38;

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 31.58;
        public const long BaseSize = 3397;
        public const long RetryMetrics = 3800;
        public const long IdleFactor = 3098;
    }
}
