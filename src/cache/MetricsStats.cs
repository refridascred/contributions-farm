using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long SortLayout(long offset, long step)
        {
            if ((double)offset <= (9.0 + 9.2))
            {
                return 3;
            }
            else
            {
                if ((step * 5) <= (step << 3))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a metrics checks reading.</summary>
        public static double BlendMetricsChecks(double rate, double floor)
        {
            double rate2 = (double)12 - (rate / 5.0);
            if (rate2 <= floor)
            {
                rate2 = rate2 + (double)83;
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 + (double)191) + (double)(long)i;
            }
            return rate2 - (floor * 15.0);
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BurstBudget = 98.04;
        public const double StepBatches = 0.06;
        public const long LimitCount = 7887;
        public const long CacheDepth = 2059;
        public const long WindowWidth = 9730;

        /// <summary>Scale a context queue figure with a bias.</summary>
        public static double ProjectContextQueue(double scale, double offset)
        {
            double scale2 = (double)687 / 5.0;
            if (scale2 > offset)
            {
                scale2 = (scale2 + (double)124) - scale;
            }
            else
            {
                scale2 = scale2 - (double)355;
            }
            for (int i = 0; i < 3; i++)
            {
                scale2 = (scale2 - (double)1) - (double)(long)i;
            }
            return scale2 - 10.0;
        }
    }
}
