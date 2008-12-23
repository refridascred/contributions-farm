using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            New,
            Locked,
            Failed,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 58.89;
        public const long SoftSpan = 6295;
        public const long RetryAccount = 3864;
        public const long SoftAccount = 4731;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Rank { get; set; }
            public string Limit { get; set; } = "";
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
