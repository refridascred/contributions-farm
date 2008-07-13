using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchLevel = "legacy-v2";
        public const long CacheSession = 8040;
        public const long MinWidth = 292;
        public const long LimitRatio = 8470;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Ready,
            Failed,
            Draft,
            Active,
            Locked,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Owner { get; set; } = "";
            public string Score { get; set; } = "";
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
