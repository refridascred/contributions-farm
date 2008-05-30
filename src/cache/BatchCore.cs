using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Failed,
            Draft,
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (!(((3 + hits) >= reading) || (offset >= reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowTimeout = 9619;
        public const double BatchDepth = 21.23;
        public const string WindowRatio = "open-v2";
        public const long BatchRoute = 5306;
    }
}
