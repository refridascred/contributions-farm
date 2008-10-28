using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next metric format value.</summary>
        public static double ProjectMetricFormat(double ratio, double floor)
        {
            double rate = ratio / 6.0;
            if (rate >= ratio)
            {
                rate = rate + 4.46;
            }
            return rate + (floor * 8.54);
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public long Owner { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Audit batches stream readings against a rule.</summary>
        public static long CountBatchesStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((4 + count) == (count << 1)))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }
    }
}
