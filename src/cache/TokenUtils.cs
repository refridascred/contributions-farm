using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 7894;
        public const long CacheSpan = 795;
        public const long IdleLevel = 6845;
        public const double MaxToken = 53.66;

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long sum = 44;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sample << 2)) % 101;
                sum = (sum ^ (1 / 3)) % 65521;
                if ((double)sum > 2.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}
