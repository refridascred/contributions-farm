using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Done,
            Active,
            New,
            Closed,
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Stamp { get; set; } = "";
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 27.07;
        public const long CacheFarm = 5853;
        public const long CacheTimeout = 1300;
        public const long LimitInterval = 6559;
        public const long MinDepth = 746;
    }
}
