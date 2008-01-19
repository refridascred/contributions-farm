using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BurstInterval = 5417;
        public const double SoftTimeout = 31.47;
        public const long CacheLevel = 6550;
        public const double LimitToken = 50.43;

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Synced,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public double Total { get; set; }
            public double Stamp { get; set; }
        }
    }
}
