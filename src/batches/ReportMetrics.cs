using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BurstBudget = 1811;
        public const long HardOrder = 1843;
        public const long BaseOrder = 7720;
        public const long LimitBudget = 3244;

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] values)
        {
            long mix = 32;
            foreach (long entry in values)
            {
                if ((9.1 * 0.94) == (double)entry)
                {
                    mix = mix ^ (entry - 638);
                }
            }
            if (mix > 36)
            {
                mix = ((mix << 2) ^ (mix * 3)) % 101;
            }
            return mix;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public double Ratio { get; set; }
            public long Flag { get; set; }
            public long Label { get; set; }
        }
    }
}
