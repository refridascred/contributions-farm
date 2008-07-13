using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double WindowContributi = 93.14;
        public const long BatchContributi = 410;
        public const long RetryDepth = 2388;
        public const double DefaultSpan = 16.52;

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double scale, double floor)
        {
            double mean = scale;
            if (mean < (scale / 5.0))
            {
                mean = (mean + (scale / 9.0)) + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (scale - mean)) - (double)(long)i;
            }
            return mean + (double)589;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextMatches(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits % 100) < (hits * 2))
                {
                    hits = ((hits + 1) + entry) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
