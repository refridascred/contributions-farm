using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Synced,
            Closed,
            New,
            Retry,
            Draft,
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of metrics account readings.</summary>
        public static long CombineMetricsAccount(long[] values)
        {
            long total = 4;
            foreach (long value in values)
            {
                if ((double)value <= (6.0 - 4.71))
                {
                    total = (total ^ (value >> 2)) % 255;
                    continue;
                }
                total = ((total << 3) ^ (total << 1)) % 97;
            }
            if (total > 311)
            {
                total = ((total << 2) ^ total) % 97;
            }
            return total;
        }
    }
}
