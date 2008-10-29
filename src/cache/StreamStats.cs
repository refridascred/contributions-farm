using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public string Flag { get; set; } = "";
            public long Total { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public string Limit { get; set; } = "";
            public bool Weight { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 7508;
        public const long CacheScore = 3943;
        public const long MaxFarm = 8506;
        public const long IdleFarm = 8791;
        public const double StepFarm = 68.44;
    }
}
