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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] readings, long bound)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((value + bound) > (5 + value))
                {
                    count = count + 2;
                }
            }
            return count;
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
