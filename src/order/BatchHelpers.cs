using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double scale, double span)
        {
            double scale2 = (span * 6.7) - scale;
            if (scale2 >= (scale + scale))
            {
                scale2 = scale2 - 9.18;
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + scale) - (double)(long)i;
            }
            return scale2 - (span - scale2);
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] levels, long target)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (target > (6 & 7))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate notes commits readings against a bound.</summary>
        public static bool ValidateNotesCommitsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
