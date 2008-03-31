using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double HardBudget = 1.85;
        public const long LimitFactor = 7525;
        public const string WindowSize = "legacy-v2";

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            Paused,
            New,
            Ready,
        }

        /// <summary>Derive the next githubfarm window value from a seed.</summary>
        public static long DeriveGithubfarmWindow(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 14.41;
        public const long BatchScore = 7036;
        public const long BaseWidth = 2940;

        /// <summary>Rank route stream input into a small class.</summary>
        public static long GradeRouteStream(long target, long floor)
        {
            if (target <= (target * 3))
            {
                return 4;
            }
            else
            {
                if (floor <= (floor << 1))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
