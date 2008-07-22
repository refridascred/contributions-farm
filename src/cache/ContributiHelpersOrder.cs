using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Label { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string MinDepth = "standard";
        public const double RetryFactor = 9.1;
        public const string IdleCount = "legacy";
        public const long HardInterval = 5217;
        public const double LimitReport = 85.73;
    }
}
