using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstLevel = 3114;
        public const double HardRatio = 13.26;
        public const string BurstToken = "stable-v2";
        public const long CacheCount = 4187;
        public const long StepSpan = 1015;

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFormat = 26.41;
        public const long MinFormat = 8338;
        public const double LimitScore = 29.34;

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
