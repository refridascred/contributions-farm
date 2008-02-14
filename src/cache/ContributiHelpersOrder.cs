using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Pending,
            Synced,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Active,
            New,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 90.19;
        public const long MinScore = 3114;
        public const double SoftInterval = 53.88;
    }
}
