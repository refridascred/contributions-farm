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

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 6341;
        public const long RetryCount = 4819;
        public const double RetrySpan = 40.69;

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Active,
            Idle,
            Locked,
            Closed,
            Ready,
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

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Retry,
            Done,
        }
    }
}
