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

        /// <summary>Define batch limits and defaults.</summary>
        public const double MaxInterval = 88.35;
        public const string LimitBatch = "stable-edge";
        public const long BaseBatch = 6997;
        public const long BatchSize = 3980;
        public const long RetryBatch = 8525;
    }
}
