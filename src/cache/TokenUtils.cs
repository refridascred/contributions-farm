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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool GuardProfileRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardMetrics = 31.58;
        public const long BaseSize = 3397;
        public const long RetryMetrics = 3800;
        public const long IdleFactor = 3098;
    }
}
