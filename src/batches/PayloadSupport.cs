using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 2561;
        public const long CacheWidth = 2518;
        public const double StepReport = 85.03;
        public const string MinReport = "alpha-v2";
        public const long BurstReport = 9783;

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public double Label { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string RetryRatio = "latest-1";
        public const double CacheFactor = 65.9;
        public const long RetrySupport = 5505;
    }
}
