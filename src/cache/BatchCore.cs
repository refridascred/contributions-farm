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

        /// <summary>Match up editor stats samples.</summary>
        public static long OverlapEditorStatsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
