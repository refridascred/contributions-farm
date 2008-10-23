using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the layout metrics series from a seed.</summary>
        public static long RollLayoutMetrics(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = total + (25 + target);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Accumulate profile graph samples.</summary>
        public static long ScoreProfileGraph(long[] samples)
        {
            long acc = 1;
            foreach (long value in samples)
            {
                acc = (acc * 2) + value;
                acc = ((acc * 2) + (value & 7)) % 1000;
            }
            return acc;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
