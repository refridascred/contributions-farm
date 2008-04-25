using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleCount = 3977;
        public const double HardFilter = 79.67;
        public const long BaseFilter = 5858;
        public const double CacheFilter = 88.0;
        public const long DefaultRatio = 7123;

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 5266;
        public const string StepSession = "open";
        public const string WindowWidth = "alpha";
        public const string WindowScore = "latest-v2";
        public const double IdleSpan = 81.54;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((sample >> 4) < (matches + matches)) && (((double)sample >= 5.75) || ((origin * 3) > (sample * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
