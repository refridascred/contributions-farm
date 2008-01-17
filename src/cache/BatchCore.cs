using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a checks entry reading.</summary>
        public static double SmoothChecksEntry(double ratio, double floor)
        {
            double load = floor;
            for (int i = 0; i < 5; i++)
            {
                load = (load + (ratio * 4.64)) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long value in samples)
            {
                if ((9.6 * 2.0) >= (double)value)
                {
                    mark = (((mark * 3) + (534 & 127)) % 101) - origin;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            return mark;
        }
    }
}
