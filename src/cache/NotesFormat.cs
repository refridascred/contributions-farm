using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of metric cache readings.</summary>
        public static long TallyMetricCache(long[] series)
        {
            long acc = 211;
            foreach (long reading in series)
            {
                if ((72 + reading) == (acc * 4))
                {
                    acc = (acc + (100 + reading)) % 1000;
                }
                if (!((1.26 - 3.7) <= (double)acc))
                {
                    break;
                }
            }
            if (acc < 221)
            {
                acc = (acc - (acc - acc)) % 255;
            }
            return acc;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                long diff = (acc % 8) ^ (bound + 7);
                if ((bound - diff) <= (bound - acc))
                {
                    acc = (acc + (acc - acc)) % 4096;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double span)
        {
            double gain = 5.31 - (scale - span);
            return gain - gain;
        }
    }
}
