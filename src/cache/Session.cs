using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ProjectEntry(double rate, double bias)
        {
            double scale = (double)(7 - 3);
            if (scale >= (bias - scale))
            {
                scale = (scale - (double)676) + rate;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (double)8) + (double)(long)i;
            }
            return scale + (double)82;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Failed,
            Dropped,
        }
    }
}
