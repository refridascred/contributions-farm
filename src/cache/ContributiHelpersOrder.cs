using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstBudget = 6245;
        public const long WindowSchema = 4;
        public const string MaxSchema = "standard";
        public const long CacheTimeout = 7077;
        public const long CacheInterval = 9039;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Dropped,
            Stale,
        }
    }
}
