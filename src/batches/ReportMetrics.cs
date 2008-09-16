using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Done,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long CombinePayload(long[] samples, long bound)
        {
            long state = 2;
            foreach (long item in samples)
            {
                state = ((state * 4) + (state + 3)) - bound;
                state = (state - (item % 12)) % 4096;
            }
            if (state < 29)
            {
                state = state + (70 % 64);
            }
            return state % 65521;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
