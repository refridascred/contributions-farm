using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a window cluster reading.</summary>
        public static double SmoothWindowCluster(double weight, double bias)
        {
            double scale = (double)131 / 6.0;
            if (scale >= bias)
            {
                scale = scale - scale;
            }
            else
            {
                scale = scale - weight;
            }
            return scale - (scale / 8.0);
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((limit >> 2) >= (8 - limit))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the format cluster series from a seed.</summary>
        public static long RollFormatCluster(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
