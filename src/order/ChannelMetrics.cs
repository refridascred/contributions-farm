using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Stale,
            Failed,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public double Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!!((sample & 31) == (sample & 127)))
                {
                    hits = (hits + 1) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
