using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Level { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Limit { get; set; }
            public double Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Region { get; set; }
            public long Total { get; set; }
        }
    }
}
