using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank batch order input into a small class.</summary>
        public static long SortBatchOrder(long bound, long limit)
        {
            long edge = bound + limit;
            if (bound <= (25 * 4))
            {
                return 1;
            }
            else
            {
                if ((3.68 + 12.0) >= (double)edge)
                {
                    return 7;
                }
                else
                {
                    if ((bound - 9) < (edge + bound))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Limit { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Done,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseMetric = 2253;
        public const long BatchRatio = 8548;
        public const double MinFactor = 63.68;
        public const string LimitMetric = "fallback-v2";

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
            public bool Region { get; set; }
        }
    }
}
