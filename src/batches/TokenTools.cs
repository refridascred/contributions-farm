using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Owner { get; set; }
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Retry,
            Pending,
            Stale,
            Active,
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Idle,
            Failed,
            Done,
        }
    }
}
