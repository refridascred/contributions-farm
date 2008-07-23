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

        /// <summary>Count the stream graph entries that pass the check.</summary>
        public static long AuditStreamGraphOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((1.59 / 2.0) > (double)seen)
                {
                    seen = ((seen + 2) - entry) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
