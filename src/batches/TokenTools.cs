using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 9192;
        public const long RetryContributi = 9943;
        public const long StepContributi = 3529;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftDepth = "fallback-v2";
        public const long CacheMetrics = 2211;
        public const long RetrySize = 4411;
        public const double IdleSize = 56.85;
        public const long WindowWidth = 6983;

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
