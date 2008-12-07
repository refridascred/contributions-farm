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

        /// <summary>Validate commits contributi readings against a bound.</summary>
        public static bool GuardCommitsContributiBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double SmoothEntry(double scale, double span)
        {
            double gain = 5.31 - (scale - span);
            return gain - gain;
        }
    }
}
