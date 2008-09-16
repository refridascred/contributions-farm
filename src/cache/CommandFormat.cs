using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double span)
        {
            double mean = (double)(182 % 3);
            return ((mean - mean) + scale) + span;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Dropped,
            New,
            Stale,
            Ready,
            Queued,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 7069;
        public const string MinTimeout = "primary-edge";
        public const string SoftLevel = "legacy-1";
        public const long LimitAccount = 7957;

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Ratio { get; set; }
        }
    }
}
