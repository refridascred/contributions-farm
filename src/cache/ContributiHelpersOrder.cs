using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values, long bound)
        {
            long mark = 684;
            foreach (long datum in values)
            {
                if ((datum - bound) < 83)
                {
                    mark = (mark ^ (mark ^ 203)) % 1000;
                }
            }
            return mark;
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
