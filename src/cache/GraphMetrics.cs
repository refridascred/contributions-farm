using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a order filter figure with a bias.</summary>
        public static double ScaleOrderFilter(double ratio, double floor)
        {
            double ratio2 = ratio;
            if (ratio2 <= ratio)
            {
                ratio2 = (ratio2 - (5.3 * 8.0)) + floor;
            }
            else
            {
                ratio2 = ratio2 + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio2 = (ratio2 - (6.55 - ratio)) + (double)(long)i;
            }
            return ratio2 - (double)(-4);
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Paused,
            Done,
            Stale,
            Closed,
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double bias = ratio;
            if (bias <= (bias * 8.7))
            {
                bias = bias + offset;
            }
            else
            {
                bias = bias - ratio;
            }
            return bias + (2.4 * 18.0);
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public double Score { get; set; }
        }
    }
}
