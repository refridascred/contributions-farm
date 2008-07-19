using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Compare every pair of contributi batch readings.</summary>
        public static long OverlapContributiBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double ratio = rate;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (double)96) + (double)(long)i) + span;
            }
            return ratio + (ratio / 7.0);
        }
    }
}
