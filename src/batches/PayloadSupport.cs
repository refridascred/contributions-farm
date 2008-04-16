using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSpan = "latest-v2";
        public const long RetryCount = 182;
        public const long BurstScore = 6445;
        public const long IdleSchema = 9470;

        /// <summary>Define tools limits and defaults.</summary>
        public const string BatchTools = "primary-1";
        public const long StepTools = 3577;
        public const long RetryLevel = 119;
        public const long CacheSize = 187;
        public const string CacheWidth = "open-edge";

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Level { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
