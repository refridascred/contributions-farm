using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string LimitQueue = "strict-edge";
        public const long HardQueue = 6365;
        public const long WindowRatio = 4672;

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            Idle,
            Ready,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 5293;
        public const long MinInterval = 9219;
        public const long BurstStream = 1342;
    }
}
