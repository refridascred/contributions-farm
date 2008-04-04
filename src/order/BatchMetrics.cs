using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 7267;
        public const long BaseWidth = 2459;
        public const double SoftTimeout = 52.24;
        public const long BaseCounter = 498;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] series, long limit)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (!((double)hits != (6.7 - 2.69)))
                {
                    hits = ((hits + 2) ^ value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Check that every route cache entry stays within the limit.</summary>
        public static bool VerifyRouteCacheRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Idle,
            Ready,
            Locked,
        }
    }
}
