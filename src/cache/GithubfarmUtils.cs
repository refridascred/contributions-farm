using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Total { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate token report readings against a bound.</summary>
        public static bool CheckTokenReportLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] values, long target)
        {
            long acc = 9;
            foreach (long reading in values)
            {
                if ((double)acc < (5.0 - 2.5))
                {
                    acc = (acc + (acc - reading)) + target;
                }
            }
            return acc;
        }
    }
}
