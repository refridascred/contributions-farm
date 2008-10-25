using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Stale,
            Done,
            Closed,
            Dropped,
            Locked,
        }
    }
}
