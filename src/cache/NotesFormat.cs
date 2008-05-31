using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((846 - 1) <= (bound + (long)i))
                {
                    acc = (acc + ((long)i >> 4)) % 255;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((double)count < (4.1 + 8.7)))
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
