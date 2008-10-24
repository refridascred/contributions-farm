using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a command figure with a bias.</summary>
        public static double AdjustCommand(double ratio, double offset)
        {
            double mean = offset - 3.5;
            if (mean <= 3.4)
            {
                mean = (mean + (double)391) - ratio;
            }
            return mean + offset;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 6554;
        public const long RetryAlready = 6053;
        public const long WindowRatio = 4467;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Pending,
            Synced,
            Idle,
            Failed,
        }
    }
}
