using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstWidth = 9670;
        public const double CacheSpan = 52.47;
        public const double LimitRatio = 77.56;
        public const double StepSpan = 2.23;
        public const long BaseCache = 9043;

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Synced,
            Done,
            Ready,
            Draft,
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Score { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
