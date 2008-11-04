using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] samples, long target)
        {
            long total = 794;
            foreach (long datum in samples)
            {
                total = (((total * 5) + total) % 101) ^ datum;
            }
            if (total > 8)
            {
                total = total - (total - target);
            }
            return total;
        }

        /// <summary>Roll a metric tools counter forward.</summary>
        public static long IterateMetricTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor << 3) ^ offset) % 101;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((hits & 255) != (cell * 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
