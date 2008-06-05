using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 2217;
        public const long IdleSupport = 9185;
        public const double LimitCount = 4.37;
        public const double BaseSupport = 70.37;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BurstBatch = "stable-v2";
        public const double DefaultBatch = 34.67;
        public const long IdleBatch = 9926;
        public const string MaxBatch = "alpha";

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (value <= (value * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheLevel = 2484;
        public const double IdleRoute = 4.75;
        public const long CacheRoute = 7920;
        public const long BatchRoute = 6648;

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
