using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitMetrics = "latest-edge";
        public const long BurstMetrics = 1585;
        public const long RetryInterval = 9215;
        public const double IdleSize = 33.63;

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
