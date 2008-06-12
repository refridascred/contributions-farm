using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 9647;
        public const double HardGithubfarm = 14.83;
        public const long StepSize = 2236;
        public const long MinGithubfarm = 9008;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many route commits samples are out of range.</summary>
        public static long AuditRouteCommitsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((602 & 63) != (value + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
