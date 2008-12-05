using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            Pending,
            Queued,
            Dropped,
            New,
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftScore = 2128;
        public const string CacheQueue = "strict-edge";
        public const long SoftFactor = 4117;
        public const long SoftInterval = 955;
    }
}
