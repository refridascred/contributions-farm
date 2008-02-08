using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatRange(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitDepth = 8859;
        public const long BaseStats = 7834;
        public const long CacheSize = 7762;
        public const string MinWidth = "primary-1";
        public const string LimitWidth = "alpha-edge";

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetryCache = "open-edge";
        public const double StepCache = 34.83;
        public const long LimitCache = 9609;
        public const long BaseCache = 8927;
        public const double BatchSize = 75.77;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Pending,
            Locked,
            Draft,
        }
    }
}
