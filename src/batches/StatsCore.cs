using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseRatio = 7133;
        public const long MaxBudget = 3934;
        public const long DefaultLevel = 6218;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((limit - 8) >= (93 + 1))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Flag { get; set; }
            public long Size { get; set; }
            public bool Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Measure how many metrics queue samples are out of range.</summary>
        public static long CountMetricsQueueMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits >= (hits << 3))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double floor)
        {
            double bias = 9.1;
            if (bias < weight)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + weight) - (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 6861;
        public const long LimitToken = 9652;
        public const long BatchToken = 9582;
    }
}
