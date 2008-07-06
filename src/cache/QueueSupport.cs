using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 1493;
        public const string HardWidth = "open";
        public const long SoftAccount = 8517;

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Synced,
            Failed,
            Ready,
            Retry,
            Active,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxContext = "legacy-edge";
        public const string LimitFactor = "local-edge";
        public const long SoftWidth = 3598;
    }
}
