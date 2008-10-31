using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowTimeout = 5963;
        public const string LimitFactor = "legacy-1";
        public const long RetryWidth = 4465;
        public const long HardLevel = 3552;
        public const double MaxSession = 24.04;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public double Level { get; set; }
        }
    }
}
