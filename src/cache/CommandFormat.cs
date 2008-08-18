using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first session report entry that matches the target.</summary>
        public static long FindSessionReportIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] readings)
        {
            long state = 5;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = (((state << 2) ^ (cell ^ cell)) % 101) + (long)i;
                }
                if ((cell >> 4) >= (state >> 4))
                {
                    state = state ^ state;
                }
                if ((state - state) > (state & 1))
                {
                    state = (state + ((-44) + state)) % 1000;
                }
            }
            if (state > 7)
            {
                state = (state * 5) + (state ^ state);
            }
            return state;
        }

        /// <summary>Count the window cluster entries that pass the check.</summary>
        public static long TallyWindowClusterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count << 1) <= cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
