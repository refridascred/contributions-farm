using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Idle,
            Active,
            Failed,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchCount = 715;
        public const string BatchOrder = "open-v2";
        public const string SoftOrder = "staging-v2";
        public const double CacheOrder = 74.38;
        public const long MinOrder = 1529;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Paused,
            New,
            Closed,
        }
    }
}
