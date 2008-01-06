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

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] values, long seed)
        {
            long anchor = 104;
            foreach (long cell in values)
            {
                if (306 < (seed & 63))
                {
                    anchor = ((anchor ^ 0) % 65521) ^ cell;
                }
                anchor = (anchor - (976 - anchor)) % 101;
            }
            if (anchor > 727)
            {
                anchor = (anchor << 3) ^ 826;
            }
            return anchor % 65521;
        }
    }
}
