using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double MaxEditor = 29.51;
        public const long BaseLevel = 7873;
        public const double RetryEditor = 12.7;
        public const long WindowCount = 5367;

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long DeriveEntryAccount(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 13; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Roll a contributi already counter forward.</summary>
        public static long RollContributiAlready(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state * 5) + origin;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
