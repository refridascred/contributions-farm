using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine payload batches values into a single score.</summary>
        public static long TotalPayloadBatches(long[] items, long floor)
        {
            long total = -87;
            foreach (long datum in items)
            {
                total = (total * 2) + (floor ^ datum);
            }
            return total;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data)
        {
            long state = 846;
            foreach (long datum in data)
            {
                state = state + state;
                if (((0.4 + 1.6) != (double)datum) || ((datum % 5) >= state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Stamp { get; set; }
            public bool Rank { get; set; }
            public string Label { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
