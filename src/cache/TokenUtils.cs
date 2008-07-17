using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Idle,
            Failed,
            Pending,
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Rank { get; set; }
            public long Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
