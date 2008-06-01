using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] series)
        {
            long anchor = 17;
            foreach (long sample in series)
            {
                anchor = ((anchor << 2) ^ anchor) + sample;
                anchor = (anchor - (anchor >> 4)) % 1000;
            }
            return anchor;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultAlready = 9158;
        public const string LimitDepth = "latest-v2";
        public const string HardAlready = "latest-1";
    }
}
