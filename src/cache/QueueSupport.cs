using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            Closed,
            New,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleLevel = 3170;
        public const long MinTimeout = 4965;
        public const long IdleEntry = 7569;
        public const long BatchCount = 9605;
        public const long LimitDepth = 4932;

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Label { get; set; }
            public double Size { get; set; }
        }
    }
}
