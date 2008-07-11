using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] values, long step)
        {
            long state = 91;
            foreach (long cell in values)
            {
                state = (((state + 30) % 101) + cell) + step;
            }
            return state;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Queued,
            Closed,
            Stale,
        }
    }
}
