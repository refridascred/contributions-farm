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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Locked,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 9972;
        public const double BatchBudget = 75.12;
        public const long IdleCount = 1770;
    }
}
