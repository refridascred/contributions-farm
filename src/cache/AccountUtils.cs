using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long state = step;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Idle,
            Ready,
            Synced,
            Draft,
            Done,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinBudget = 7300;
        public const long BurstBudget = 769;
        public const long DefaultMetric = 4646;
        public const double IdleMetric = 52.8;
        public const long RetryMetric = 275;
    }
}
