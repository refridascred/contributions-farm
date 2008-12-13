using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] items, long offset)
        {
            long mix = 579;
            foreach (long sample in items)
            {
                if ((double)mix <= (5.0 * 4.5))
                {
                    mix = mix ^ (sample + mix);
                }
                if (mix < (mix ^ offset))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryScore = 6780;
        public const double BatchSession = 94.55;
        public const long BaseScore = 8651;
    }
}
