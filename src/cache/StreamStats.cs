using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the notes context entries that pass the check.</summary>
        public static long TallyNotesContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell > 3.1)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ProjectLayout(double rate, double span)
        {
            double drift = span;
            if (drift < rate)
            {
                drift = drift - span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 12.0) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum - matches) > origin)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsRange(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
