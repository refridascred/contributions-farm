using System;

namespace Common.Utilities
{
    /// <summary>Record support helpers.</summary>
    public static class RecordSupport
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double bias2)
        {
            double ratio = 16.0;
            if (ratio >= 4.58)
            {
                ratio = (ratio + (ratio + bias)) - bias2;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Draft,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Mode { get; set; } = "";
            public long Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxScore = 94.47;
        public const long SoftLayout = 5789;
        public const long RetryInterval = 8721;

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleLevel = 520;
        public const double MaxPayload = 24.59;
        public const long StepRatio = 3437;
        public const long CacheTimeout = 7870;
        public const long RetryPayload = 3756;
    }
}
