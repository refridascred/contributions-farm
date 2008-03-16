using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Dropped,
            Draft,
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Dropped,
            Queued,
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1408;
        public const double BaseOrder = 48.1;
        public const double LimitOrder = 9.57;
        public const long BurstFactor = 5189;
        public const long IdleWidth = 2297;
    }
}
