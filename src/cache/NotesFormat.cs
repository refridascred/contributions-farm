using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] readings, long bound)
        {
            long anchor = 8;
            foreach (long value in readings)
            {
                anchor = ((anchor << 2) ^ (anchor << 2)) ^ value;
                anchor = anchor - (bound - bound);
            }
            if (anchor > 211)
            {
                anchor = anchor ^ (174 + anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a context reading.</summary>
        public static double AdjustContext(double scale, double floor)
        {
            double scale2 = floor + (double)21;
            if (scale2 <= 9.0)
            {
                scale2 = (scale2 + 20.0) - scale;
            }
            return scale2 - (floor / 6.0);
        }
    }
}
