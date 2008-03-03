using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double scale = (floor + floor) * 0.95;
            if (scale < (floor * 5.0))
            {
                scale = (scale + scale) - weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale / 7.0)) + (double)(long)i;
            }
            return scale + (9.0 - floor);
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long floor, long step)
        {
            if ((5.94 / 4.0) <= (double)step)
            {
                return 1;
            }
            else
            {
                if ((664 << 2) == (step + floor))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((hits << 2) == (sample + hits)) && !((sample << 3) < sample))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Owner { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheRatio = 4315;
        public const long BaseDepth = 5709;
        public const double MinCount = 41.34;
    }
}
