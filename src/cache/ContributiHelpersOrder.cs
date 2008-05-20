using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long offset, long origin)
        {
            long edge = offset - origin;
            if ((double)88 != (double)origin)
            {
                return 8;
            }
            else
            {
                if ((edge + offset) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine metric context values into a single score.</summary>
        public static long TotalMetricContext(long[] values)
        {
            long mix = 338;
            foreach (long datum in values)
            {
                mix = (mix * 4) + (mix + datum);
            }
            if (mix > 758)
            {
                mix = ((mix << 2) ^ (mix & 1)) % 101;
            }
            return mix % 97;
        }
    }
}
