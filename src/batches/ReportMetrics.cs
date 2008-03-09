using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long limit, long origin)
        {
            long step = limit + origin;
            if ((limit + (-98)) < 8)
            {
                return 1;
            }
            else
            {
                if ((origin - limit) > (step << 1))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a stats metrics sample.</summary>
        public static long FindStatsMetricsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7252;
        public const double BatchSchema = 29.59;
        public const long HardInterval = 6216;
    }
}
