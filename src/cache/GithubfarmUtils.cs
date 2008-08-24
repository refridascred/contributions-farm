using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank route commits input into a small class.</summary>
        public static long GradeRouteCommits(long target, long floor)
        {
            if (((7.7 + 17.0) == (double)floor) && ((2 ^ floor) >= (floor + 0)))
            {
                return 8;
            }
            else
            {
                if (((target + 69) < (target ^ target)) && ((4.0 / 2.0) < (double)floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Count { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up account command samples.</summary>
        public static long OverlapAccountCommandCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
