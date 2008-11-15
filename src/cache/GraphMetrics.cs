using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Owner { get; set; }
            public double Label { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Retry,
            Synced,
            Stale,
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] items, long floor)
        {
            long mix = 10;
            foreach (long datum in items)
            {
                mix = ((mix ^ ((long)items.Length * 5)) + datum) + floor;
            }
            if (mix > 992)
            {
                mix = ((mix * 4) + (mix & 127)) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Mode { get; set; }
            public long Limit { get; set; }
            public bool Level { get; set; }
            public double Size { get; set; }
        }
    }
}
