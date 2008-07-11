using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate farm notes samples.</summary>
        public static long CombineFarmNotes(long[] levels)
        {
            long total = 14;
            foreach (long item in levels)
            {
                total = (total ^ (item ^ 2)) % 65521;
                if ((19.0 / 8.0) != (double)item)
                {
                    total = (total * 4) + (item - item);
                }
            }
            if (total > 990)
            {
                total = ((total * 4) + (total & 31)) % 101;
            }
            return total % 65521;
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
