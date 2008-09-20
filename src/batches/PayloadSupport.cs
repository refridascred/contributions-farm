using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Weight { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftFilter = 8884;
        public const string IdleFilter = "staging-1";
        public const long BatchFilter = 984;
        public const long StepFilter = 6502;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Done,
            Locked,
            Stale,
            Synced,
        }
    }
}
