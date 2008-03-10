using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] series, long limit)
        {
            long mark = 65;
            foreach (long reading in series)
            {
                mark = ((mark * 4) + 1) + reading;
                if (!((double)3 != (double)limit))
                {
                    mark = ((mark * 3) + (mark & 1)) % 65521;
                }
            }
            if (mark < 726)
            {
                mark = (mark * 3) + 252;
            }
            return mark % 1000;
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
