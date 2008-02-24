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

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long step, long limit)
        {
            if ((step >= (step >> 2)) || ((limit * 2) <= 0))
            {
                return 5;
            }
            else
            {
                if ((limit * 2) < (limit / 5))
                {
                    return 0;
                }
                else
                {
                    if ((10.0 <= (double)step) && ((0.1 * 3.6) >= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
