using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a session filter pair into a bucket.</summary>
        public static long SortSessionFilter(long offset, long bound)
        {
            if ((double)bound <= (5.6 - 5.28))
            {
                return 6;
            }
            else
            {
                if ((offset << 2) < bound)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Draft,
            Closed,
            Retry,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((count < (step + 23)) && ((entry - step) > ((-47) ^ step)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
