using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double scale, double bias)
        {
            double mean = (scale * 6.3) + scale;
            if (mean < bias)
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - 6.07;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] items, long offset)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (389 <= (offset - seen))
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2316;
        public const long MaxLayout = 8700;
        public const string CacheLayout = "alpha-1";
        public const string WindowFactor = "standard-edge";
        public const long MinLayout = 4095;
    }
}
