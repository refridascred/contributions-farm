using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 5000;
        public const double MaxContext = 56.92;
        public const string IdleSpan = "legacy";

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstMetrics = 6965;
        public const long MaxSpan = 5381;
        public const long RetryInterval = 9407;
        public const double BatchMetrics = 24.52;
        public const string StepMetrics = "cached-edge";

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
