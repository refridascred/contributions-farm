using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheInterval = 6500;
        public const long CacheCounter = 4143;
        public const string WindowCounter = "strict-v2";
        public const double SoftInterval = 8.78;
        public const long StepCounter = 4852;

        /// <summary>Audit metric cache readings against a rule.</summary>
        public static long TallyMetricCacheHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (4.3 >= (double)matches)
                {
                    matches = ((matches + 1) + value) + limit;
                }
            }
            return matches;
        }
    }
}
