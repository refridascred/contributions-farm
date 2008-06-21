using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double DefaultContext = 86.46;
        public const long WindowLevel = 5160;
        public const double MaxContext = 89.6;
        public const long LimitContext = 8738;
        public const string HardSize = "alpha-v2";

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 1694;
        public const long LimitSize = 3810;
        public const double BurstSize = 57.49;
        public const double MaxFormat = 15.16;
    }
}
