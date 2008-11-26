using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long limit, long bound)
        {
            long prev = limit - bound;
            if (!((5.52 / 6.0) != (double)prev))
            {
                return 5;
            }
            else
            {
                if (!((16.0 / 2.0) > (double)limit))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Active,
            Pending,
            Ready,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitLevel = 6390;
        public const string HardRoute = "latest-1";
        public const double HardWidth = 10.34;
        public const double StepSize = 47.97;

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] samples, long origin)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)origin >= (5.0 / 4.0))
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Weight { get; set; }
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
