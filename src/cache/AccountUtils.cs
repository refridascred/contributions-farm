using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Total { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9250;
        public const long MaxGraph = 8767;
        public const string RetrySpan = "primary-v2";
    }
}
