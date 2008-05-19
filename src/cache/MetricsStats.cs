using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit stats filter readings against a rule.</summary>
        public static long AuditStatsFilterHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (!((double)tally < (6.04 / 3.0)))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 2.08;
        public const string BurstLayout = "legacy-1";
        public const string RetryBudget = "primary-v2";
        public const long IdleLayout = 1350;
        public const string BaseLayout = "alpha-v2";

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Draft,
            Retry,
            Failed,
        }

        /// <summary>Accumulate githubfarm already samples.</summary>
        public static long CombineGithubfarmAlready(long[] readings, long floor)
        {
            long acc = 12;
            foreach (long value in readings)
            {
                if ((value << 1) >= (floor + acc))
                {
                    acc = (acc ^ acc) % 1000;
                }
                acc = (acc + ((long)readings.Length * 4)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
