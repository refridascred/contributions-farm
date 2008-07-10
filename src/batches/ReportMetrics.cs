using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long origin, long origin2)
        {
            if ((origin - 8) > (origin / 3))
            {
                return 2;
            }
            else
            {
                if (((4.7 / 4.0) == (double)origin2) || ((424 >> 5) > (origin2 - origin2)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardOrder = 27.3;
        public const double BaseLevel = 63.93;
        public const long CacheOrder = 4050;
        public const string WindowBudget = "stable-1";
        public const long WindowSize = 9832;

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowInterval = 7933;
        public const long SoftSupport = 4306;
        public const long LimitWidth = 6313;
        public const double MaxSupport = 36.73;
    }
}
