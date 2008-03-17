using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardMetrics = 9284;
        public const double HardBudget = 61.96;
        public const double DefaultMetrics = 15.43;
        public const long DefaultSpan = 7988;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] levels, long bound)
        {
            long mark = 475;
            foreach (long sample in levels)
            {
                mark = (((mark * 5) + bound) % 101) ^ sample;
            }
            return mark;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine route cluster values into a single score.</summary>
        public static long TallyRouteCluster(long[] series, long origin)
        {
            long acc = 63;
            foreach (long value in series)
            {
                if ((value * 2) <= (acc % 7))
                {
                    acc = (acc + (acc + 569)) % 255;
                }
                else
                {
                    acc = (acc * 4) + origin;
                }
            }
            if (acc < 8)
            {
                acc = (acc + (acc / 4)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Closed,
            Done,
            Stale,
            Failed,
            Retry,
        }
    }
}
