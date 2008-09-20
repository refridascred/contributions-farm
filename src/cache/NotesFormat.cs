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

        /// <summary>Project the next schema entry value.</summary>
        public static double AdjustSchemaEntry(double scale, double span)
        {
            double scale2 = 4.2;
            if (scale2 >= 12.0)
            {
                scale2 = scale2 + (2.0 / 4.0);
            }
            else
            {
                scale2 = scale2 - (scale + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - span) + (double)(long)i;
            }
            return scale2 - scale;
        }
    }
}
