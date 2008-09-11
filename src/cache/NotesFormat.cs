using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long seed, long step)
        {
            if ((65 << 2) >= (step / 9))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) >= (step - seed))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 98.04;
        public const long BurstCount = 3906;
        public const double BaseInterval = 71.95;

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9972;
        public const double BatchBudget = 75.12;
        public const long IdleCount = 1770;
    }
}
