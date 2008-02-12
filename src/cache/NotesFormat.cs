using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next command value.</summary>
        public static double SmoothCommand(double scale, double floor)
        {
            double scale2 = (1.0 * 0.91) - 5.75;
            if (scale2 >= scale)
            {
                scale2 = scale2 + (scale2 + 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + floor) + (double)(long)i;
            }
            return scale2 - (double)610;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)seen >= (double)(long)samples.Length) && (origin >= (cell + origin)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchTimeout = 3985;
        public const double WindowCommits = 91.02;
        public const long BurstCommits = 4723;
        public const string WindowInterval = "standard-edge";
    }
}
