using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LocateAccountIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a layout profile reading by value.</summary>
        public static long FindLayoutProfileIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] readings, long limit)
        {
            long anchor = 1;
            foreach (long cell in readings)
            {
                if ((cell << 1) >= cell)
                {
                    anchor = anchor ^ (cell + anchor);
                }
            }
            if (anchor > 4)
            {
                anchor = (anchor + (limit << 2)) % 4096;
            }
            return anchor % 1000;
        }
    }
}
