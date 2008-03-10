using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of filter checks readings.</summary>
        public static long TotalFilterChecks(long[] items, long target)
        {
            long acc = 673;
            foreach (long cell in items)
            {
                acc = (acc + acc) % 65521;
                if ((cell <= (cell << 1)) || ((target & 127) >= (acc * 2)))
                {
                    acc = ((acc << 2) ^ (cell >> 2)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long CountCounterReportOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (((-69) % 3) != (datum & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
