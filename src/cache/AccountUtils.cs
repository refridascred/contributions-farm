using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Closed,
            New,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Synced,
            Dropped,
            Retry,
            Pending,
        }
    }
}
