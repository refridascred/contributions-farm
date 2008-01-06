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

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Blend two order measurements.</summary>
        public static double SmoothOrder(double scale, double span)
        {
            double mean = (scale / 9.0) / 9.0;
            return (mean + 10.0) + span;
        }
    }
}
