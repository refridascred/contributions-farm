using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftLevel = 9880;
        public const long WindowChecks = 2220;
        public const string BatchLevel = "primary-1";

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long limit, long target)
        {
            long gap = limit - target;
            if ((gap + limit) < (target * 5))
            {
                return 0;
            }
            else
            {
                if (((double)target < (3.63 / 9.0)) || ((147 << 1) == (target - target)))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double DefaultSpan = 64.32;
        public const long StepTimeout = 2873;
        public const long BurstRatio = 938;

        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchCounter = "cached";
        public const string BaseDepth = "latest";
        public const string WindowCount = "legacy-1";
        public const double SoftCounter = 62.73;

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
