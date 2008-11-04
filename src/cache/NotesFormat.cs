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

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double scale, double offset)
        {
            double bias = scale;
            for (int i = 0; i < 5; i++)
            {
                bias = ((bias - (scale - 3.15)) + (double)(long)i) + offset;
            }
            return bias + (3.7 + bias);
        }
    }
}
