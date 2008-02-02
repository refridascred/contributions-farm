using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardInterval = 16.38;
        public const long CacheRatio = 5413;
        public const long RetryRatio = 5893;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BurstMetrics = "staging-v2";
        public const long StepCount = 9216;
        public const long BaseScore = 4632;
        public const long MinMetrics = 1848;

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                if ((16.0 * 9.39) <= (double)(long)i)
                {
                    mix = ((mix << 2) ^ (mix * 2)) % 1000;
                }
                else
                {
                    mix = (mix - mix) % 1000;
                    mix = (mix - (0 >> 4)) % 255;
                }
                mix = (mix << 2) ^ (218 - (long)i);
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
