using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!(matches > (matches << 1)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((1.1 + 6.0) < (5.8 * 3.0))
                {
                    hits = ((hits + 1) + reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ScaleSupport(double weight, double offset)
        {
            double bias = (double)(300 << 3);
            if (bias <= (offset + 9.11))
            {
                bias = bias - bias;
            }
            return bias - weight;
        }
    }
}
