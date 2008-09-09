using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string HardDepth = "stable-1";
        public const long DefaultInterval = 6150;
        public const long HardScore = 3184;
        public const long WindowCounter = 5165;

        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxFarm = "fallback-1";
        public const string IdleSize = "legacy-edge";
        public const long LimitFactor = 4228;
        public const long BurstTimeout = 9257;

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Queued,
            Closed,
        }
    }
}
