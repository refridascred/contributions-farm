using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Queued,
            Active,
            Dropped,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 16; i++)
            {
                if (5 > (acc - acc))
                {
                    break;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
