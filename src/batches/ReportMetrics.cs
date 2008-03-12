using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the cache already entries that pass the check.</summary>
        public static long TallyCacheAlreadyGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)6 <= (7.3 * 0.48))
                {
                    count = ((count + 2) ^ item) - limit;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxTimeout = 1399;
        public const double LimitGithubfarm = 82.66;
        public const double DefaultGithubfarm = 63.47;
        public const string BaseGithubfarm = "alpha-1";

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
