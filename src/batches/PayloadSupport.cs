using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BatchSize = 51.76;
        public const long MinSession = 3566;
        public const long CacheSession = 372;

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 8509;
        public const double CacheWindow = 47.2;
        public const long BaseRatio = 3619;
    }
}
