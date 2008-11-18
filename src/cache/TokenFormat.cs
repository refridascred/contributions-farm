using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of route commits readings.</summary>
        public static long DigestRouteCommits(long[] samples, long target)
        {
            long sum = 775;
            foreach (long sample in samples)
            {
                if ((target ^ target) <= 61)
                {
                    sum = (sum * 5) + (sum % 12);
                }
                else
                {
                    sum = sum ^ (target + target);
                }
                if (!((sum - target) >= (sum - sample)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6748;
        public const long CacheCount = 5131;
        public const long MinFilter = 4099;
        public const long DefaultDepth = 1511;
        public const long DefaultFilter = 7671;

        /// <summary>Project the next window profile value.</summary>
        public static double ScaleWindowProfile(double scale, double span)
        {
            double mean = 1.0 * 3.3;
            if (mean >= mean)
            {
                mean = (mean - (double)2) + scale;
            }
            return mean - span;
        }
    }
}
