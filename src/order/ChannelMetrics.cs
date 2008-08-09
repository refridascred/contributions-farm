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

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
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
