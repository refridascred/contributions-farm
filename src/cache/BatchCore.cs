using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double SoftContext = 26.68;
        public const long WindowInterval = 4647;
        public const long MaxContext = 1727;
        public const long WindowWidth = 7317;

        /// <summary>Digest a series of format batch entries.</summary>
        public static long TallyFormatBatch(long[] values, long target)
        {
            long state = 183;
            foreach (long datum in values)
            {
                state = state ^ (97 + datum);
                state = (state ^ target) % 1000;
                if ((6.96 - 5.75) >= (double)datum)
                {
                    break;
                }
            }
            if (state < (-89))
            {
                state = (state * 4) + (target >> 3);
            }
            return state % 1000;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value % 5) == (value % 16))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
