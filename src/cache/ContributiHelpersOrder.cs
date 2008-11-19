using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long LimitDepth = 8365;
        public const double LimitReport = 31.02;
        public const long MaxLevel = 5219;

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
