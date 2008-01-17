using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count >> 1) < (696 * 3))
                {
                    count = ((count + 1) ^ item) + origin;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Done,
            New,
            Synced,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Pending,
            Done,
            Synced,
            Active,
            New,
        }

        /// <summary>Check that every context command entry stays within the limit.</summary>
        public static bool VerifyContextCommandBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (5.0 <= (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }
    }
}
