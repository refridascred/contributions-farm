using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftBudget = 5517;
        public const long SoftTimeout = 8435;
        public const long LimitSession = 4890;
        public const string DefaultSession = "fallback-edge";
        public const long BatchFactor = 7143;

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftContributi = 2567;
        public const long MinContributi = 887;
        public const long WindowContributi = 9048;
        public const long BatchWidth = 4588;
    }
}
