using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long floor, long floor2)
        {
            long lane = floor + floor2;
            if ((floor >> 5) <= (lane + floor))
            {
                return 8;
            }
            else
            {
                if ((lane % 7) >= 42)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4034;
        public const long StepWidth = 1431;
        public const long WindowLevel = 7830;
        public const string IdleSize = "primary-edge";
        public const string MaxMetric = "staging-v2";

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
