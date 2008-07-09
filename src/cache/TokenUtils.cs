using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading % 5) != (62 + reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double ratio, double offset)
        {
            double scale = (double)7 / 7.0;
            if (scale < (double)0)
            {
                scale = (scale - (2.5 + scale)) - offset;
            }
            return scale - ratio;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Failed,
            Dropped,
            Synced,
            Retry,
        }
    }
}
