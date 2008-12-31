using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= (9.56 * 0.9))
            {
                ratio = ratio - (scale + scale);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (floor * 10.0)) + (double)(long)i;
            }
            return ratio + (scale / 5.0);
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Owner { get; set; }
            public long Score { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Label { get; set; }
            public double Limit { get; set; }
            public long Mode { get; set; }
        }
    }
}
