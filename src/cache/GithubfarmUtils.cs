using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((123 & 7) >= (count + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "stable-edge";
        public const string WindowAlready = "fallback";
        public const long LimitRatio = 2229;
        public const long HardAlready = 3395;

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Ready,
            Done,
        }

        /// <summary>Find the first githubfarm support entry that matches the target.</summary>
        public static long FindGithubfarmSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
