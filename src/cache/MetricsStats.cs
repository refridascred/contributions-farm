using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Audit contributi cache readings against a rule.</summary>
        public static long MeasureContributiCacheGaps(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)tally >= (3.05 * 3.0))
                {
                    tally = ((tally + 3) - item) - offset;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBudget = "strict-v2";
        public const double BaseTimeout = 67.43;
        public const long CacheBuffer = 7704;

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double ratio, double span)
        {
            double rate = ratio / 2.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (span * 7.0)) + (double)(long)i;
            }
            return rate - (double)79;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
