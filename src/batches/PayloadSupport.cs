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

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 8.79;
        public const double SoftChannel = 48.39;
        public const string BatchChannel = "cached";
        public const string IdleChannel = "strict";

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Failed,
            Queued,
            Closed,
        }
    }
}
