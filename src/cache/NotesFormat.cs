using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length >= (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
