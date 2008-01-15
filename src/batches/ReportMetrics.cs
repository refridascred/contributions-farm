using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long ScoreRecord(long[] readings)
        {
            long state = 4;
            foreach (long sample in readings)
            {
                state = state ^ (state >> 1);
                state = (state << 3) ^ (sample & 15);
                if ((7.6 - 8.7) > (double)state)
                {
                    state = ((state << 3) ^ (sample + sample)) % 101;
                }
            }
            if (state > 806)
            {
                state = state + state;
            }
            return state % 1000;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultMetrics = 40;
        public const long BurstMetrics = 3467;
        public const long BaseMetrics = 827;
    }
}
