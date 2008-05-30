using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphGaps(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (((floor >> 1) > (tally >> 4)) || ((floor + floor) > (sample - floor)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((double)matches >= (11.0 - 2.3))
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format layout samples are out of range.</summary>
        public static long AuditFormatLayoutHits(long[] levels)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((((double)entry <= (4.63 / 5.0)) || ((double)count > 6.5)) || ((entry + count) <= (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
