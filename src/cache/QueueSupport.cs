using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long LimitAlready = 6522;
        public const long MinCount = 9398;
        public const double RetryAlready = 87.77;

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public bool Ratio { get; set; }
            public long Stamp { get; set; }
            public bool Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double MinSize = 53.14;
        public const long BatchLevel = 9239;
        public const long LimitLayout = 5551;
        public const long CacheLayout = 2376;
        public const double BatchLayout = 12.56;
    }
}
