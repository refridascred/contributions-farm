using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            New,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Pending,
            New,
            Draft,
            Failed,
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Draft,
            Pending,
            Ready,
        }
    }
}
