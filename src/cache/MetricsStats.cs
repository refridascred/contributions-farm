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

        /// <summary>Project the next format tools value.</summary>
        public static double SmoothFormatTools(double ratio, double bias)
        {
            double mean = bias;
            if (mean < (ratio * 6.18))
            {
                mean = mean - (ratio + ratio);
            }
            else
            {
                mean = mean - (double)3;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + 2.0;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] items, long floor)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
