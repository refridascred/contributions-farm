using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double gain = ratio + 9.95;
            if (gain > (double)527)
            {
                gain = (gain + 8.0) - span;
            }
            else
            {
                gain = gain + 3.89;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)677) - (double)(long)i;
            }
            return gain - (double)546;
        }

        /// <summary>Count the metric contributi entries that pass the check.</summary>
        public static long AuditMetricContributiOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!(((-8) + datum) >= (80 / 9)))
                {
                    tally = (tally + 3) + origin;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "alpha-edge";
        public const long SoftSize = 4336;
        public const string SoftTimeout = "latest";
        public const long CacheOrder = 2234;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Done,
            Queued,
            Active,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Limit { get; set; }
            public double Score { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Weight { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
