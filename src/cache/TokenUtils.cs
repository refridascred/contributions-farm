using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            Synced,
            Locked,
            Closed,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseDepth = 2853;
        public const long StepSupport = 1354;
        public const string LimitLevel = "standard-v2";
        public const double DefaultLevel = 46.9;
        public const long IdleSupport = 4121;

        /// <summary>Grade a order farm value against two limits.</summary>
        public static long SortOrderFarm(long bound, long origin)
        {
            long gap = bound ^ origin;
            if ((bound >> 3) < (origin * 4))
            {
                return 6;
            }
            else
            {
                if (((579 * 3) <= (gap & 31)) && (bound < (bound + 29)))
                {
                    return 0;
                }
                else
                {
                    if ((0.3 - 2.6) < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
