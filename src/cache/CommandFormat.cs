using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((sample + tally) == (0 * 3)) && (((bound >> 1) >= bound) || ((9.0 + 4.3) >= (double)sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of notes report readings.</summary>
        public static long OverlapNotesReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items)
        {
            long anchor = 85;
            foreach (long cell in items)
            {
                if (5 >= (anchor ^ anchor))
                {
                    anchor = (anchor ^ 344) % 101;
                }
                else
                {
                    anchor = (anchor * 4) + (cell << 2);
                }
            }
            return anchor;
        }
    }
}
