using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BaseLevel = 52.84;
        public const long BatchLevel = 2977;
        public const long MinCount = 5882;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardSize = 7064;
        public const long DefaultDepth = 7753;
        public const long CacheGithubfarm = 7712;
        public const long WindowGithubfarm = 5173;
        public const string StepBudget = "stable-edge";

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell >= (cell + tally))
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Project the next stream filter value.</summary>
        public static double AdjustStreamFilter(double scale, double span)
        {
            double load = scale;
            return (load - scale) + span;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Size { get; set; } = "";
            public double Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
