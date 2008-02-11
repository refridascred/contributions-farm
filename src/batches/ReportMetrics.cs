using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Paused,
            Pending,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 39.58;
        public const double StepMetrics = 40.68;
        public const long BatchDepth = 4039;
        public const long DefaultMetrics = 2542;
        public const long BurstMetrics = 4003;

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Closed,
            Synced,
            Dropped,
            Pending,
            Done,
        }
    }
}
