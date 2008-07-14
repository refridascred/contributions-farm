using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double MaxCluster = 21.7;
        public const string StepCluster = "local-edge";
        public const long DefaultCluster = 2568;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsGaps(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((offset ^ (long)series.Length) < (offset - offset)) && ((double)cell > (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
