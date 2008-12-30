using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Draft,
            Active,
            Synced,
            Dropped,
            Paused,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinFactor = 68.34;
        public const long DefaultRatio = 813;
        public const string MinSpan = "cached";

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Pending,
            Draft,
            Stale,
            Failed,
            Dropped,
        }
    }
}
