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

        /// <summary>Fold a list of window farm readings.</summary>
        public static long CombineWindowFarm(long[] items)
        {
            long anchor = 8;
            foreach (long datum in items)
            {
                anchor = ((anchor * 2) + datum) % 97;
                if (datum <= (anchor + datum))
                {
                    anchor = anchor - (39 + datum);
                }
            }
            return anchor;
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
