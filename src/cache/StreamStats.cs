using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Limit { get; set; }
            public bool Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Count { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 2186;
        public const long BatchCount = 4568;
        public const long HardRecord = 4272;
        public const long RetryLevel = 7229;
        public const double SoftRatio = 23.2;
    }
}
