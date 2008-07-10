using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Locked,
            Queued,
            Draft,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardRecord = 64.07;
        public const long CacheWidth = 9162;
        public const long SoftRecord = 7449;
        public const long DefaultInterval = 2704;
        public const long DefaultRecord = 5731;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
