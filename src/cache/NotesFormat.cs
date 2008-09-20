using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long total = offset;
            for (int i = 0; i < 18; i++)
            {
                total = total ^ (881 >> 2);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double scale, double floor)
        {
            double load = 1.4;
            if (load >= (load / 2.0))
            {
                load = (load + (floor * 6.32)) + scale;
            }
            else
            {
                load = load - 15.0;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (load * 5.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value > (count - (-20)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
