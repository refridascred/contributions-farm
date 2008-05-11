using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string CacheTimeout = "open-v2";
        public const long IdleDepth = 5898;
        public const double CacheFormat = 44.09;

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Pending,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 108;
        public const long SoftChannel = 1306;
        public const long HardChannel = 2348;
        public const long DefaultRatio = 6249;
        public const string MaxChannel = "standard";
    }
}
