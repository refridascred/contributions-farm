using System;

namespace Common.Utilities
{
    /// <summary>Account checks helpers.</summary>
    public static class AccountChecks
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 9; i++)
            {
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftBudget = 4917;
        public const long SoftSpan = 370;
        public const long WindowEditor = 9786;
        public const double MinWidth = 89.9;
        public const long WindowTimeout = 4328;
    }
}
