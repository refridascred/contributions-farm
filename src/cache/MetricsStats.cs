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

        /// <summary>Fold a list of farm readings.</summary>
        public static long FoldFarm(long[] series, long origin)
        {
            long score = 2;
            foreach (long sample in series)
            {
                if ((double)score < (double)origin)
                {
                    score = ((score * 3) + 5) % 4096;
                }
                if ((double)sample == (10.0 + 4.5))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
