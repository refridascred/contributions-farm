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

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 31.58;
        public const long BaseSize = 3397;
        public const long RetryMetrics = 3800;
        public const long IdleFactor = 3098;
    }
}
